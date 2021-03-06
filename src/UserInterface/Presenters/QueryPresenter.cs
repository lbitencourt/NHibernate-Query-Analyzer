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
using System.Text.RegularExpressions;
using Ayende.NHibernateQueryAnalyzer.Core.Model;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Commands;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Interfaces;
using Ayende.NHibernateQueryAnalyzer.Utilities;
using NHibernate;
using NHibernate.Cfg;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Presenters
{
	/// <summary>
	/// Summary description for QueryPresenter.
	/// </summary>
	public class QueryPresenter : IQueryPresenter
	{
		private readonly IMainPresenter mainPresenter;
		private readonly IQueryView view;
		private Query query;
		public const string DefaultName = "New Query";

		public QueryPresenter(IMainPresenter mainPresenter):this(mainPresenter, new Query(DefaultName,string.Empty))
		{}

		public QueryPresenter(IMainPresenter mainPresenter, Query query)
		{
			this.mainPresenter = mainPresenter;
			this.query = query;
			this.view = CreateView();
		}

		private static readonly Regex parameters = new Regex(@"(?<=:)\w+", RegexOptions.Compiled);

        //public virtual void PopulateEntitiesInEntityExplorer()
        //{
        //    mainPresenter.CurrentProject.
        //}

        public Configuration NHibernateConfiguration
        {
            get { return mainPresenter.CurrentProject.NHibernateConfiguration; }
        }

        public virtual SortedList MappingFiles
        {
            get { return mainPresenter.CurrentProject.MappingFiles; }
        }
        

		public virtual string TranslateHql()
		{
			try
			{
				if (QueryCanBeTranslated())
				{
					string[] sql = mainPresenter.CurrentProject.HqlToSql(view.HqlQueryText, view.Parameters);
					string result = string.Join("; ", sql);
					view.SqlQueryText = result;
					return result;
				}
				else
				{
					string result = "Some parameters were not set, cannot translate query.";
					view.SqlQueryText = result;
					return result;
				}
			}
			//Notice, this should usually be QueryException, but it can be other things, so we'll 
			// just handle every exception as an error from the query.
			catch (Exception ex)
			{
				view.AddException(ex);
				return ex.Message;
			}
		}

		public virtual void ExecuteQuery()
		{
			if (QueryCanBeTranslated())
			{
				TypedParameter[] typedParameters = ConvertDictionaryToTypedParameterArray(view.Parameters);
				ICommand execQuery = new ExecuteQueryCommand(view, mainPresenter.CurrentProject, view.HqlQueryText, typedParameters);
				mainPresenter.EnqueueCommand(execQuery);
				view.StartWait("Executing query", 100, 1000);
			}
			else
			{
				view.ShowError("Can't execute query before all parameters are set");
			}
		}

		public bool QueryCanBeTranslated()
		{
			return HasParameters(view.HqlQueryText) == false || AllParametersSet();
		}

		private static TypedParameter[] ConvertDictionaryToTypedParameterArray(IDictionary parameters)
		{
			if (parameters == null)
				return new TypedParameter[0];
			TypedParameter[] typedParameters = new TypedParameter[parameters.Count];
			int i = 0;
			foreach (DictionaryEntry entry in parameters)
			{
				typedParameters[i] = ((TypedParameter) entry.Value);
				i++;
			}
			return typedParameters;
		}

		public virtual bool HasParameters(string queryText)
		{
			return parameters.IsMatch(queryText);
		}

		public virtual bool AllParametersSet()
		{
			foreach (Match match in parameters.Matches(view.HqlQueryText))
			{
				TypedParameter parameter = (TypedParameter) view.Parameters[match.Value];
				if (parameter == null || parameter.Value == null || parameter.Type == null)
					return false;
			}
			return true;
		}

		public virtual bool ReplaceException(Exception newException, Exception lastException)
		{
			if (newException.GetType() == lastException.GetType())
			{
				if (newException.GetType() == typeof (QueryException))
					return true;
				if (newException.Message == lastException.Message)
					return true;
			}
			return false;
		}

		public IQueryView View
		{
			get
			{
				return view;
			}
		}

		public virtual void AnalyzeParameters()
		{
			Hashtable visibleParameters = new Hashtable(view.Parameters);
			MatchCollection matches = parameters.Matches(view.HqlQueryText);
			foreach (Match match in matches)
			{
				if (visibleParameters.Contains(match.Value))
					//remove previous mark of missing
					view.SetParameterMissing(match.Value, false);
				else
					view.SuggestParameter(match.Value);
				visibleParameters.Remove(match.Value);
			}
			//mark those not found as missing
			foreach (TypedParameter parameter in visibleParameters.Values)
			{
				view.SetParameterMissing(parameter.Name, true);
			}
		}

		public bool SaveQueryAs()
		{
			string name = view.Title;
			string newName = view.Ask("Rename query to:", name);
			if (newName != null)
			{
				Query oldQuery = mainPresenter.CurrentProject.GetQueryWithName(newName);
				if (oldQuery != null)
				{
					if(view.AskYesNo("A query with thename '" + newName + "' already exists, are you sure you want to overwrite it?", "Overwrite query?"))
						mainPresenter.CurrentProject.RemoveQuery(oldQuery);
					else
						return false;
				}
				if(Query.OwnerProject==null)
					mainPresenter.CurrentProject.AddQuery(Query);
				Query.Name = newName;
				view.Title = newName;
				mainPresenter.Repository.SaveQuery(Query);
				view.HasChanges = false;
				return true;
			}
			return false;
		}

		public bool SaveQuery()
		{
			if (Query.Name == DefaultName)
				return SaveQueryAs();
			mainPresenter.Repository.SaveQuery(Query);
			view.HasChanges = false;
			return true;
		}

		protected virtual IQueryView CreateView()
		{
			return new QueryForm(this, mainPresenter.View);
		}

		public Query Query
		{
			get { return query; }
			set { query = value; }
		}

        //public NHibernate.Cfg.Configuration NHibernateConfiguration
        //{
        //    get { return mainPresenter.CurrentProject.NHibernateConfiguration; }
        //    set { nHibernateConfiguration = value; }
        //}


       

	}
}
