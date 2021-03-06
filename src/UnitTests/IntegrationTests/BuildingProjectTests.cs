﻿#region license
// Copyright (c) 2005 - 2007 Ayende Rahien (ayende@ayende.com)
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//     * Neither the name of Ayende Rahien nor the names of its
//     contributors may be used to endorse or promote products derived from this
//     software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
// THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion


using System;
using System.Collections;
using System.Data;
using System.Reflection;
using Ayende.NHibernateQueryAnalyzer.Core.Model;
using Ayende.NHibernateQueryAnalyzer.ProjectLoader;
using Ayende.NHibernateQueryAnalyzer.Tests.TestUtilities;
using Ayende.NHibernateQueryAnalyzer.Utilities;
using NHibernate;
using MbUnit.Framework;

namespace Ayende.NHibernateQueryAnalyzer.UnitTests.IntegrationTests
{
	[TestFixture]
	//[Category("Integration")]
	public class BuildingProjectTests
	{
		private Project current;
		private string prjName = "NewProject";
	
		private const string hqlQuery = "from TestProject", 
		                     parametrizedQuery = "from TestProject tp where tp.Id = :id";
		private const string tableName = "TestFile";

		[TestFixtureSetUp]
		public void TestFixtureSetup()
		{
			current = new Project(prjName, new Project.Context());
			current.AddFile(TestDataUtil.TestConfigFile);
			current.AddFile(TestDataUtil.TestDllFile);
			current.AddFile(TestDataUtil.TestMappingFile);
			current.BuildProject();
		}

		[TestFixtureTearDown]
		public void TestFixtureTearDown()
		{
			current.Dispose();
		}
		[Test]
		public void GetHqlObjectGraph()
		{
			IList list = current.RunHql(hqlQuery);
			RemoteObject so;
			Assert.IsTrue(current.IsSessionOpen, "Session is not opened even though is wasn't closed.");
			Assert.AreEqual(2003, list.Count);
			Assert.AreEqual(typeof (RemoteObject), list[0].GetType());
			Assert.AreEqual(typeof (RemoteObject), list[1].GetType());
			so = (RemoteObject) list[0];
			Assert.AreEqual("TestProject", so.TypeName);
			Assert.AreEqual("TestProject.TestProject", so.FullTypeName);
		}

		[Test]
		public void GetDataSet()
		{
			DataSet ds = current.RunHqlAsRawSql(hqlQuery);
			Assert.IsNotNull(ds.Tables[tableName], "Table was not found");
			Assert.AreEqual(2003, ds.Tables[tableName].Rows.Count, "Row count on table is wrong");
			Assert.AreEqual(2, ds.Tables[tableName].Rows[1][0], "wrong value on id column");
			Assert.AreEqual("More Testing", ds.Tables[tableName].Rows[1][1], "wrong value on data column");
		}

		[Test]
		public void GetHqlObjectGraph_FromParametrizedQuery()
		{
			TypedParameter param = new TypedParameter("id", typeof (int), 2);
			IList list = current.RunHql(parametrizedQuery, param);
			RemoteObject so;
			Assert.IsTrue(current.IsSessionOpen, "Session is not opened even though is wasn't closed.");
			Assert.AreEqual(1, list.Count);
			Assert.AreEqual(typeof (RemoteObject), list[0].GetType());
			so = (RemoteObject) list[0];
			Assert.AreEqual("TestProject", so.TypeName);
			Assert.AreEqual("TestProject.TestProject", so.FullTypeName);
		}

		[Test]
		public void GetDataSet_FromParametrizedQuery()
		{
			TypedParameter param = new TypedParameter("id", typeof (int), 2);
			DataSet ds = current.RunHqlAsRawSql(parametrizedQuery, param);
			Assert.IsNotNull(ds.Tables[tableName], "Table was not found");
			Assert.AreEqual(1, ds.Tables[tableName].Rows.Count, "Row count on table is wrong");
			Assert.AreEqual(2, ds.Tables[tableName].Rows[0][0], "wrong value on id column");
			Assert.AreEqual("More Testing", ds.Tables[tableName].Rows[0][1], "wrong value on data column");

		}

		/// <summary>
		/// The purpose of this test is to make sure that an exception raised
		/// from this method is not remoting exception and that the data is preserved
		/// across app domains even if not all the exceptions can be serialized.
		/// </summary>
		[Test]
		[ExpectedException(typeof (QueryException), "query must begin with SELECT or FROM: bad [bad hql query]")]
		public void RunHql_ExceptionCanBeSerialized()
		{
			current.RunHql("bad hql query");
		}

		/// <summary>
		/// The purpose of this test is to make sure that an exception raised
		/// from this method is not remoting exception and that the data is preserved
		/// across app domains even if not all the exceptions can be serialized.
		/// </summary>
		[Test]
        [ExpectedException(typeof(QueryException))]
		public void RunSql_ExceptionCanBeSerialized()
		{
            current.RunHqlAsRawSql("bad hql query");
		}

		[Test]
		public void CreateAppDomainAndConfiguration()
		{
			Assert.IsTrue(current.IsProjectBuilt, "Project was not built");
			Assert.AreEqual(current.Name, current.AppDomain.FriendlyName, "AppDomain name was not set correctly.");
			Assert.IsNotNull(current.AppDomain, "App domain was not created successfully");
		}

		[Test]
		public void ResetProjectAfterBuilding()
		{
			Project resetable = new Project("Resetabble Project");
			resetable.AddFile(TestDataUtil.TestConfigFile);
			resetable.AddFile(TestDataUtil.TestDllFile);
			resetable.AddFile(TestDataUtil.TestMappingFile);
			resetable.BuildProject();
			Assert.IsTrue(resetable.IsProjectBuilt, "Project was not built");
			SerializableTestClassForDomainUnload testUnload = new SerializableTestClassForDomainUnload();
			resetable.AppDomain.DomainUnload += new EventHandler(testUnload.AppDomain_DomainUnload);
			resetable.ResetProject();
			Assert.IsFalse(resetable.IsProjectBuilt, "Project was not reset properly");
			Assert.IsTrue(testUnload.ProjectAppDomainWasUnloaded, "Project's AppDomain was not unloaded");
			Assert.IsNull(resetable.AppDomain, "AppDomain was no released.");
			
			resetable.Dispose();
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException),"Can't add files to a project that has been built, call reset and try again")]
		public void CantAddFilesAfterProjectWasBuilt()
		{
			this.current.AddFile(TestDataUtil.TestConfigFile);
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException),"Can't remove files to a project that has been built, call reset and try again")]
		public void CantRemoveFilesAfterProjectWasbuilt()
		{
			this.current.RemoveFile(TestDataUtil.TestConfigFile);
		}

		[Test]
		public void ViewLazyCollection()
		{
            IList list = current.RunHql("from TestProject");
			RemoteObject ro = list[0] as RemoteObject;
			Assert.IsNotNull(ro,"the query first object was null or not a remote object");
			RemoteList filesList = ro["Files"] as RemoteList;
			Assert.IsNotNull(filesList,"the query first object's files property was null or not a remote object");
			RemoteObject filesObj = filesList[0] as RemoteObject;
			Assert.IsNotNull(filesObj["Test"]);
		}


		[Serializable]
		private class SerializableTestClassForDomainUnload : MarshalByRefObject
		{
			public bool ProjectAppDomainWasUnloaded = false;

			public void AppDomain_DomainUnload(object sender, EventArgs e)
			{
				ProjectAppDomainWasUnloaded = true;
			}
		}
	}
}
