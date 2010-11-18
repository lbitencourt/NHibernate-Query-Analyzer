using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Controls;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Interfaces;
using Ayende.NHibernateQueryAnalyzer.Utilities;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface
{
    public partial class QueryForm : NQADocument, IQueryView
    {
        private const int MaxExceptionCount = 35;
        private readonly IQueryPresenter presenter;
        private readonly Hashtable parameters = new Hashtable();
        private readonly SortedList<string, int> entites = new SortedList<string, int>();
        private readonly SortedList<string, string> aliases = new SortedList<string, string>();
        private readonly IList<Entity> entityList = new List<Entity>();

        bool moveCursorOnePositionLess;

        SortedList<string, string> Properties = new SortedList<string, string>();

        public QueryForm(IQueryPresenter presenter, IView parentView)
            : base(parentView)
        {
            this.presenter = presenter;
            InitializeComponent();
        }

        private void GetAllEntitiesAndAddInEntityExplorer()
        {
            try
            {
                SortedList list = presenter.MappingFiles;
                TreeNode MainNode = new TreeNode("Entities");
                int KeyCounter = 1;
                MainNode.ImageIndex = 4;
                MainNode.SelectedImageIndex = 4;

                foreach (DictionaryEntry dictionaryEntity in list)
                {
                    MappingEntity entity = dictionaryEntity.Value as MappingEntity;
                    Entity entityForList = new Entity
                                               {
                                                   Name = entity.EntityName
                                               };
                    entites.Add(entity.EntityName, KeyCounter);
                    KeyCounter++;

                    TreeNode entityNode = new TreeNode(string.Format("{0} [{1}]", entity.EntityName, entity.TableName))
                                              {
                                                  Tag = entity.EntityName,
                                                  ImageIndex = 0,
                                                  SelectedImageIndex = 0
                                              };
                    foreach (System.Collections.Generic.KeyValuePair<string, MappingEntityProperty> m_property in entity.Properties)
                    {
                        MappingEntityProperty property = m_property.Value;

                        TreeNode PropertyNode = new TreeNode(string.Format("{0} [{1}]", property.PropertyName, property.PropertyType))
                                                    {
                                                        ImageIndex = 1,
                                                        SelectedImageIndex = 1,
                                                        Tag = property.PropertyName
                                                    };
                        entityNode.Nodes.Add(PropertyNode);
                        entityForList.Properties.Add(property.PropertyName, property.ReturnClassName);
                    }

                    MainNode.Nodes.Add(entityNode);
                    entityList.Add(entityForList);
                }
                ux_EntityExplorer.Nodes.Add(MainNode);
                MainNode.Expand();
                ux_EntityExplorer.EndUpdate();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
        }

        public bool ShowParams
        {
            get { return ux_QueryParameters.Visible; }
            set
            {
                if (ux_QueryParameters.Visible != value)
                    ux_ParameterSplitter.ToggleState();
            }
        }

        private void ux_ExceptionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ux_ExceptionDetail.Text = (ux_ExceptionsList.SelectedItems.Count > 0)
                ? ux_ExceptionsList.SelectedItems[0].Tag.ToString()
                : "";
        }

        private void ux_Query_TextChanged(object sender, EventArgs e)
        {
            presenter.Query.Text = ux_Query.Text;
            HasChanges = true;
            presenter.TranslateHql();
            if (presenter.HasParameters(HqlQueryText))
            {
                HandleParameters();
            }
        }

        private void HandleParameters()
        {
            ShowParams = true;
            ux_ParameterSuggestions.Items.Clear();
            ux_ParameterSuggestions.Text = "";
            presenter.AnalyzeParameters();
        }

        #region IQueryView Implementation

        public string QueryText
        {
            get { return ux_Query.Text; }
            set { ux_Query.Text = value; }
        }

        public override bool Save()
        {
            return presenter.SaveQuery();
        }

        public string HqlQueryText
        {
            get { return ux_Query.Text; }
        }

        public IDictionary Parameters
        {
            get { return parameters; }
        }

        public string SqlQueryText
        {
            get { return ux_SqlQuery.Text; }
            set
            {
                ux_SqlQuery.Text = value;
                ux_Results.SelectedTab = ux_ResultsSql;
                ux_Query.Select();
            }
        }

        public override void AddException(Exception ex)
        {
            ux_Results.SelectedTab = ux_ResultsExceptions;
            if (ux_ExceptionsList.Items.Count > 0 && presenter.ReplaceException(ex, (Exception)ux_ExceptionsList.Items[0].Tag))
            {
                ux_ExceptionsList.Items[0].Text = ex.Message;
                ux_ExceptionsList.Items[0].Tag = ex;
            }
            else
            {
                ListViewItem exception = new ListViewItem(ex.Message)
                                             {
                                                 Tag = ex
                                             };
                ux_ExceptionsList.Items.Insert(0, exception);
                if (ux_ExceptionsList.Items.Count > MaxExceptionCount)
                    ux_ExceptionsList.Items.RemoveAt(ux_ExceptionsList.Items.Count - 1);
            }
            ux_Query.Select();
        }

        public void DisplayObjectGraph(IList list)
        {
            RemoteObjectDisplayGraphControl odgc = new RemoteObjectDisplayGraphControl
                                                       {
                                                           Text = "Query result: #"
                                                       };
            odgc.DisplayObject(list);
            odgc.Text = "Query returned " + list.Count + " results";
            if (ux_ObjectGraph.Root != null)
                ux_ObjectGraph.Root.Delete();
            ux_ObjectGraph.AddRoot(odgc);
            odgc.Expand();
        }

        public void DisplayDataSet(DataSet ds)
        {
            if (ds.Tables.Count == 1)
                ux_DatabaseGrid.DataSource = ds.Tables[0];
            else
                ux_DatabaseGrid.DataSource = ds;

        }

        public void SuggestParameter(string name)
        {
            if (!ux_ParameterSuggestions.Items.Contains(name))
                ux_ParameterSuggestions.Items.Add(name);
            ux_ParameterSuggestions.SelectedItem = name;
        }

        public void RemoveSuggestParameter(string name)
        {
            ux_ParameterSuggestions.Items.Remove(name);
        }

        public void RemoveParameter(string name)
        {
            parameters.Remove(name);
            ux_QueryParameters.SelectedItems[0].Remove();
            HandleParameters();
        }

        public void SetParameterMissing(string name, bool missingState)
        {
            foreach (ListViewItem item in ux_QueryParameters.Items)
            {
                if (item.Text == name)
                {
                    item.ForeColor = missingState ? Color.Red : Color.FromKnownColor(KnownColor.ControlText);
                    break;
                }
            }
        }

        public void ShowObjectGraph()
        {
            ux_Results.SelectedTab = ux_ResultsObjectGraph;
            ux_QueryPanel.Visible = false;
        }

        public IQueryPresenter QueryPresenter
        {
            get { return presenter; }
        }

        private void ux_QueryParameters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ux_DeleteParameter.Enabled = ux_QueryParameters.SelectedItems.Count > 0;
        }

        private void ux_AddParameter_Click(object sender, EventArgs e)
        {
            using (AddParameter ap = new AddParameter(ux_ParameterSuggestions.Text))
            {
                if (ap.ShowDialog(this) == DialogResult.Cancel)
                    return;
                RemoveTopSuggestParameter();
                SetQueryParameter(ap.Parameter);
            }
        }

        private void SetQueryParameter(TypedParameter parameter)
        {
            foreach (ListViewItem item in ux_QueryParameters.Items)
            {
                if (item.Text == parameter.Name)
                {
                    item.Remove();
                    break;
                }
            }
            ListViewItem lvi = new ListViewItem(new[]
                                                    {
                                                        parameter.Name,
                                                        parameter.Type.Name,
                                                        parameter.Value.ToString()
                                                    });
            lvi.Tag = parameter;
            parameters[parameter.Name] = parameter;
            ux_QueryParameters.Items.Add(lvi);
            presenter.TranslateHql();
            presenter.AnalyzeParameters();
        }

        private void RemoveTopSuggestParameter()
        {
            ux_ParameterSuggestions.Items.Remove(ux_ParameterSuggestions.Text);
            if (ux_ParameterSuggestions.Items.Count > 0)
                ux_ParameterSuggestions.SelectedItem = ux_ParameterSuggestions.Items[0];
            else
                ux_ParameterSuggestions.Text = "";
        }

        private void ux_DeleteParameter_Click(object sender, EventArgs e)
        {
            string paramName = ux_QueryParameters.SelectedItems[0].Text;
            RemoveParameter(paramName);
        }

        public bool CanExecuteQuery
        {
            get { return presenter.QueryCanBeTranslated(); }
        }

        #endregion

        public override bool SaveAs()
        {
            return presenter.SaveQueryAs();
        }

        private void ux_QueryParameters_ItemActivate(object sender, EventArgs e)
        {
            using (AddParameter ap = new AddParameter(ux_QueryParameters.SelectedItems[0].Tag as TypedParameter))
            {
                if (ap.ShowDialog(this) == DialogResult.OK)
                {
                    SetQueryParameter(ap.Parameter);
                }
            }
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            Title = presenter.Query.Name;
            ux_Query.Text = presenter.Query.Text;
            HasChanges = false;

            GetAllEntitiesAndAddInEntityExplorer();
        }

        #region Intellisence Code

        private void ux_Query_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemPeriod)
            {
                AddToAliasList();

            }

            if (e.Control && e.KeyCode == Keys.Space)
            {
                if (ux_Query.Text == "")
                    return;

                int endPosition;
                int startIndex;
                int enterKeyAppender;
                string Query;
                string PartialText = GetPartialText(out Query, out startIndex, out endPosition, out enterKeyAppender);
                if (SearchForEntity(PartialText))
                    DisplayCompleteNameOfEntity(PartialText, endPosition, startIndex, enterKeyAppender);
                else
                {
                    string[] parts = PartialText.Split('.');
                    if (parts.Length > 1)
                    {
                        int startPosition = Convert.ToInt32(ux_Query.SelectionStart);
                        string entityNameFromAlias = aliases[parts[parts.Length - 2]];
                        string CompletepropertyName = GetEntityUsingProperty(entityNameFromAlias, parts[parts.Length - 1], true);
                        if (CompletepropertyName == "")
                            return;
                        string entity = GetEntityUsingProperty(entityNameFromAlias, parts[parts.Length - 1], false);
                        if (!aliases.ContainsKey(CompletepropertyName))
                            aliases.Add(CompletepropertyName, entity);
                        string CompleteText = PartialText.Substring(0, PartialText.Length - parts[parts.Length - 1].Length) + CompletepropertyName;
                        ux_Query.Text = ux_Query.Text.Replace(PartialText, CompleteText);
                        SetCursorToEnd((startPosition - parts[parts.Length - 1].Length) + CompletepropertyName.Length);
                        moveCursorOnePositionLess = true;

                    }
                }
            }
        }

        private void AddToAliasList()
        {
            int startIndex;
            int endPosition;
            int enterKeyAppender;
            string Query;
            string PartialText = GetPartialText(out Query, out startIndex, out endPosition, out enterKeyAppender);

            string[] parts = PartialText.Split('.');
            string alias = parts[0];
            string entity;
            string entityNameFromAlias;

            string currentEntity = GetEntityNameUsingAlias(PartialText, alias, false);
            if (currentEntity.Contains("."))
            {
                string[] entityNamePart = currentEntity.Split('.');
                string key = entityNamePart[entityNamePart.Length - 1];
                if (aliases.ContainsKey(key))
                    currentEntity = aliases[key];
                else
                {
                    entityNameFromAlias = aliases[entityNamePart[entityNamePart.Length - 2]];
                    currentEntity = GetEntityUsingProperty(entityNameFromAlias, entityNamePart[entityNamePart.Length - 1], true);
                    entity = GetEntityUsingProperty(entityNameFromAlias, parts[parts.Length - 1], false);
                    if (!aliases.ContainsKey(alias))
                    {
                        aliases.Add(alias, currentEntity);
                        DisplayEntityPropertiesInPropertyGrid(currentEntity);
                    }
                }

            }
            if (!aliases.ContainsKey(alias))
            {
                aliases.Add(alias, currentEntity);
                DisplayEntityPropertiesInPropertyGrid(currentEntity);
            }
            if (parts.Length > 1)
            {

                entityNameFromAlias = aliases[parts[parts.Length - 2]];
                currentEntity = GetEntityUsingProperty(entityNameFromAlias, parts[parts.Length - 1], true);
                entity = GetEntityUsingProperty(entityNameFromAlias, parts[parts.Length - 1], false);
                if (!aliases.ContainsKey(currentEntity))
                {
                    aliases.Add(currentEntity, entity);

                }

            }
            DisplayEntityPropertiesInPropertyGrid(currentEntity);

            return;
        }

        private void DisplayEntityPropertiesInPropertyGrid(string EntityName)
        {
            foreach (Entity entity in entityList)
            {
                if (entity.Name == EntityName)
                {
                    ux_Properties.Items.Clear();
                    foreach (KeyValuePair<string, string> key in entity.Properties)
                    {
                        ListViewItem item = new ListViewItem(key.Key);
                        item.SubItems.Add(key.Value);
                        ux_Properties.Items.Add(item);

                    }
                    break;
                }
            }

        }

        private bool SearchForEntity(string partial)
        {
            if (aliases.ContainsKey(partial) == false && partial.Contains("."))
                return false;
            return true;
        }

        private string GetEntityName(string partial, string text)
        {
            string[] parts = partial.Split('.');
            string alias = parts[0];

            string entityName = GetEntityNameUsingAlias(partial, alias, true);
            if (entityName.Contains("."))
            {
                string entityNameFromAlias = aliases[entityName.Split('.')[0]];
                entityName = GetEntityUsingProperty(entityNameFromAlias, entityName.Split('.')[1], false);
                string propertyname = GetEntityUsingProperty(entityName, parts[1], true);
                aliases.Add(alias, entityName);
                return propertyname;
            }
            aliases.Clear();
            aliases.Add(alias, entityName);
            for (int counter = 1; counter < parts.Length; counter++)
            {
                entityName = GetEntityUsingProperty(entityName, parts[counter], counter == parts.Length - 1);
            }
            return entityName;
        }

        private string GetEntityUsingProperty(string entityName, string propertyName, bool returnPropertyName)
        {
            foreach (Entity entity in entityList)
            {
                if (entity.Name == entityName)
                {
                    foreach (KeyValuePair<string, string> property in entity.Properties)
                    {
                        if (property.Key.ToUpper().StartsWith(propertyName.ToUpper()))
                            if (returnPropertyName)
                            {
                                return property.Key;
                            }
                            else
                            {
                                return property.Value;
                            }
                    }
                }
            }
            return "";
        }

        private string GetEntityNameUsingAlias(string Partial, string alias, bool continueSearching)
        {
            string query = RemoveReturnKeys(ux_Query.Text);
            string[] words = query.Substring(0, query.Length - Partial.Length).Split(' ');
            string[] parts = Partial.Split('.');
            for (int counter = 0; counter < words.Length; counter++)
            {
                if (words[counter].Equals(alias))
                {
                    return words[counter - 1];
                }
            }
            return "";
        }

        private void DisplayCompleteNameOfEntity(string Partial, int endPosition, int startIndex, int enterKeyAppender)
        {
            string CompleteEntityName = GetEntityNameUsingPartialEntityName(Partial);

            if (CompleteEntityName != "")
            {
                int startPosition = Convert.ToInt32(ux_Query.SelectionStart);
                ux_Query.Text = ux_Query.Text.Replace(Partial, CompleteEntityName);
                SetCursorToEnd((startPosition - Partial.Length) + CompleteEntityName.Length);
                return;
            }
        }

        private string GetPartialText(out string Query, out int startIndex, out int endPosition, out int enterKeyAppender)
        {
            Query = ux_Query.Text;
            Query = RemoveReturnKeys(Query);
            startIndex = 0;

            endPosition = GetCurrentCursorPosition();
            string Partial = string.Empty;

            // the current position of cursor..
            // 1 - could be in the middle. in that case it's less that Query.Lenght
            // 2 - at the end. in this case if user has pressed enter key, it gets addes so reset it back
            enterKeyAppender = 0;
            SetEndPosition(Query, ref endPosition, ref enterKeyAppender);
            Query = Query.Substring(0, endPosition); // this trims enter key in the end
            return GetPartialEntityName(Query, endPosition, out startIndex);
        }

        private static void SetEndPosition(string Query, ref int endPosition, ref int enterKeyAppender)
        {
            if (endPosition > Query.Length) // true if enter keys are pressed. 
            {
                enterKeyAppender = endPosition - Query.Length;
                endPosition = Query.Length;
            }
        }

        private string GetPartialEntityName(string Query, int endPosition, out int startIndex)
        {
            startIndex = 0;
            for (int counter = Query.Length - 1; counter != 0; counter--)
            {
                if (Query.Substring(counter, 1) == " ")
                    break;
                startIndex++;
            }
            return Query.Substring(endPosition - startIndex, startIndex);
        }

        private string RemoveReturnKeys(string text)
        {
            text = text.Replace("\r\n", " "); // removes all enter keys presses codes
            text = text.TrimEnd(); // gets rid of spaces in the end
            return text;
        }

        private int GetCurrentCursorPosition()
        {
            return ux_Query.SelectionStart;
        }

        private void SetCursorToEnd(int cursorPosition)
        {
            ux_Query.Focus();
            ux_Query.Select(this.ux_Query.Text.Length, 0);
            ux_Query.SelectionStart = cursorPosition;
        }

        private string GetEntityNameUsingPartialEntityName(string partialEntityName)
        {
            foreach (KeyValuePair<string, int> str in entites)
            {
                if (str.Key.ToUpper().StartsWith(partialEntityName.ToUpper()))
                    return str.Key;

            }
            return "";
        }

        private void ux_Query_KeyUp(object sender, KeyEventArgs e)
        {
            if (moveCursorOnePositionLess)
            {
                int currentPosition = ux_Query.SelectionStart;
                currentPosition--;
                SetCursorToEnd(currentPosition);
                moveCursorOnePositionLess = false;
            }
        }

        #endregion

        private void ux_Query_DragDrop(object sender, DragEventArgs e)
        {
            string data = (string)e.Data.GetData(typeof(string));
            int currentPos = ux_Query.GetCharIndexFromPosition(
                ux_Query.PointToClient(MousePosition)
                );
            string newText = ux_Query.Text.Insert(currentPos, data);
            ux_Query.Text = newText;
        }

        private void ux_Query_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.Text)
                ? DragDropEffects.Copy
                : DragDropEffects.None;
        }

        private void ux_EntityExplorer_ItemDrag(object sender, ItemDragEventArgs e)
        {
            object o = ((TreeNode)e.Item).Tag;
            if (o == null) return;

            string EntityName = o.ToString();
            DoDragDrop(EntityName, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void ux_EntityExplorer_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.Text)
                ? DragDropEffects.Copy
                : DragDropEffects.None;
        }
    }
}
