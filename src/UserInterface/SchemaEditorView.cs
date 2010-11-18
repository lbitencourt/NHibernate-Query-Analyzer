using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Ayende.NHibernateQueryAnalyzer.SchemaEditing;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Controls;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Interfaces;
using Ayende.NHibernateQueryAnalyzer.UserInterface.SchemaEditing;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface
{
    public partial class SchemaEditorView : NQADocument
    {
        private readonly SchemaEditor schemaEditor;
        private readonly SaveFileDialog saveFileDlg;
        private string filename;
        private Hashtable menuItemToField;
        private Hashtable errorsDictionary = new Hashtable();
        private object objectFromEditedXml;
        private bool xmlTextEdited;

        #region C'tors

        private SchemaEditorView(IView parentView, SaveFileDialog saveFileDlg)
            : base(parentView)
        {
            this.saveFileDlg = saveFileDlg;
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        public SchemaEditorView(IView parentView, SaveFileDialog saveFileDlg, Type rootclassType, string pathToDocument)
            : this(parentView, saveFileDlg)
        {
            schemaEditor = new SchemaEditor(rootclassType, new WinFormsSchemaEditorNodeFactory(this));
            if (pathToDocument != null)
            {
                OpenFile(pathToDocument);
            }
            else
            {
                schemaEditor.CreateDefaultRoot();
                Title = "New " + SchemaEditor.GetTypeName(rootclassType);
            }
            foreach (TreeNode node in ux_GraphTree.Nodes)
                node.Expand();
        }

        public SchemaEditorView(IView parentView, SaveFileDialog saveFileDlg, Type rootClassType) :
            this(parentView, saveFileDlg, rootClassType, null)
        {
        }

        #endregion

        #region Event Handlers

        private void ux_GraphTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            WinFormsSchemaEditorNode node = ux_GraphTree.SelectedNode as WinFormsSchemaEditorNode;
            if (node != null)
            {
                //node.DisplayCurrentElementAttributes(attributesList); //Replaced by property grid
                node.DisplayCurrentElementAttributes(ux_AttributePropertyGrid);
            }
        }

        private void ux_GraphTree_MouseHover(object sender, EventArgs e)
        {
            WinFormsSchemaEditorNode node = (WinFormsSchemaEditorNode)ux_GraphTree.GetNodeAt(ux_GraphTree.PointToClient(MousePosition));
            if (node == null || errorsDictionary.ContainsKey(node) == false)
            {
                ux_ErrorTooltip.SetToolTip(ux_GraphTree, "");
                return;
            }
            ux_ErrorTooltip.SetToolTip(ux_GraphTree, (string)errorsDictionary[node]);
        }

        private void ux_GraphTreeContextMenuAdd_Popup(object sender, EventArgs e)
        {
            ux_GraphTreeContextMenuAdd.MenuItems.Clear();
            menuItemToField = new Hashtable();
            IList items = new ArrayList(), requiredItems = new ArrayList();
            //selected node is guranteed that this will not be null by the contet menu
            foreach (NodeFieldReference field in SelectedNode.NodeFields)
            {
                if (CanAdd(field) == false)
                    continue;
                foreach (string name in field.Names)
                {
                    MenuItem item = new MenuItem(name);
                    item.Click += AddChild;
                    menuItemToField.Add(item, new object[] { SelectedNode, field.TypeMatching(name) });
                    if (field.IsRequired)
                        requiredItems.Add(item);
                    else
                        items.Add(item);
                }
            }
            if (requiredItems.Count > 0)
            {
                foreach (MenuItem item in requiredItems)
                    ux_GraphTreeContextMenuAdd.MenuItems.Add(item);
                if (items.Count > 0)
                    ux_GraphTreeContextMenuAdd.MenuItems.Add("-");//seperator
            }
            foreach (MenuItem item in items)
                ux_GraphTreeContextMenuAdd.MenuItems.Add(item);
            if (ux_GraphTreeContextMenuAdd.MenuItems.Count == 0)
                ux_GraphTreeContextMenuAdd.MenuItems.Add(ux_GraphTreeContextMenuAddNothing);
        }

        private void ux_GraphTreeContextMenu_Popup(object sender, EventArgs e)
        {
            ux_GraphTreeContextMenu.MenuItems.Clear();
            if (ux_GraphTree.SelectedNode != null)
            {
                ux_GraphTreeContextMenu.MenuItems.Add(ux_GraphTreeContextMenuAdd);
                if (ux_GraphTree.SelectedNode.Parent != null)//can't delete root element
                {
                    ux_GraphTreeContextMenu.MenuItems.Add(ux_GraphTreeContextMenuSplitter);
                    ux_GraphTreeContextMenu.MenuItems.Add(ux_GraphTreeContextMenuRemove);
                }
            }
        }

        private void ux_GraphTree_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node = ux_GraphTree.GetNodeAt(ux_GraphTree.PointToClient(MousePosition));
            if (e.Button == MouseButtons.Right && node != null)
                ux_GraphTree.SelectedNode = node;
        }

        private void ux_DocumentTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ux_DocumentTabs.SelectedTab == ux_DocumentXmlTab)
            {
                bool tmp = HasChanges;
                //from object to text, should always work
                ux_Xml.Text = schemaEditor.ToString();
                xmlTextEdited = false;
                HasChanges = tmp;//this avoid auto-setting to unsaved when switching to xmlview (Bug #27)
            }
            else
            {
                if (xmlTextEdited == false)
                    return;
                xmlTextEdited = false;
                //replace the root, 
                ux_GraphTree.Nodes.RemoveAt(0);
                //objectFromEditedXml is filled when the user switch
                schemaEditor.ReadObjectRoot(objectFromEditedXml);
                //clear the attributes list
                //attributesList.Items.Clear(); // replaced by property grid

            }
        }

        private void ux_DocumentXmlTab_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                CreataObjectFromXml();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

        }

        private void ux_GraphTreeContextMenuRemove_Click(object sender, EventArgs e)
        {
            if (ux_GraphTree.SelectedNode != null)
            {
                RemoveNode();
            }
        }

        private void ux_Xml_TextChanged(object sender, EventArgs e)
        {
            HasChanges = true;
            xmlTextEdited = true;
        }

        private void ux_AttributePropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            CheckSchema();
            HasChanges = true;
        }

        #endregion

        #region Private Methods

        private string AssureCorrectExtention(string name)
        {
            if (name.IndexOf('.') != -1)//already has extention, so just return it
                return name;
            return name + "." + saveFileDlg.DefaultExt;
        }

        private void OpenFile(string pathToDocument)
        {
            using (Stream str = File.OpenRead(pathToDocument))
            {
                XmlTextReader document = new XmlTextReader(str);
                schemaEditor.Read(document);
            }
            Title = Path.GetFileName(pathToDocument);
            filename = pathToDocument;
        }

        private void EditAttributeValue(string attName, WinFormsSchemaEditorNode node)
        {
            AttributeFieldReference attribute = (AttributeFieldReference)node.Attributes.GetByKey(attName);
            using (EditAttribute edit = new EditAttribute(attribute))
            {
                DialogResult result = edit.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;
                if (result == DialogResult.Abort && node.ActiveAttributes.Contains(attribute))
                {
                    attribute.SetToDefaultValue();
                }
                else
                {
                    attribute.Value = edit.AttributeValue;
                }
                node.RefreshTitle();
                CheckSchema();
                HasChanges = true;
            }
        }

        private void CheckSchema()
        {
            ux_ErrorList.Items.Clear();
            errorsDictionary = new Hashtable();
            SchemaErrorCollection errors = SchemaEditor.CheckSchemaCompliance(schemaEditor.RootNode);
            foreach (ISchemaError schemaError in errors)
            {
                ux_ErrorList.Items.Add(schemaError.Message);
                errorsDictionary[schemaError.ParentNode] = schemaError.Message;
            }
            if (errors.Count > 0)
                ux_ErrorList.Visible = true;
        }

        private void AddChild(object sender, EventArgs e)
        {
            object[] arr = (object[])menuItemToField[sender];
            WinFormsSchemaEditorNode node = (WinFormsSchemaEditorNode)arr[0];
            Type type = (Type)arr[1];
            schemaEditor.CreateChild(node, type);
            CheckSchema();
            HasChanges = true;
            node.Expand();
        }

        // You can add if the field is an array,
        // or if it doesn't already have a value
        private bool CanAdd(NodeFieldReference field)
        {
            return field is ArrayNodeFieldReference || field.HasValue == false;
        }

        private void CreataObjectFromXml()
        {
            XmlTextReader reader = new XmlTextReader(new StringReader(ux_Xml.Text));
            objectFromEditedXml = schemaEditor.Serializer.Deserialize(reader);
        }

        private void RemoveNode()
        {
            DialogResult answer = MessageBox.Show("Are you certain you want to remove the node '" + ux_GraphTree.SelectedNode.Text + "'?",
                                                  "Remove node?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
                return;

            schemaEditor.RemoveChild((ISchemaEditorNode)SelectedNode.Parent, SelectedNode);
            CheckSchema();
            HasChanges = true;
        }

        #endregion

        #region Overriden methods

        public override bool Save()
        {
            if (filename == null)
            {
                if (SaveAs() == false)
                    return false;
            }
            using (TextWriter writer = File.CreateText(filename))
            {
                schemaEditor.Write(writer);
            }
            HasChanges = false;
            return true;
        }

        public override bool SaveAs()
        {
            if (saveFileDlg.ShowDialog(this) == DialogResult.Cancel)
                return false;
            filename = AssureCorrectExtention(saveFileDlg.FileName);
            Title = Path.GetFileName(filename);
            return Save();
        }

        #endregion

        #region Properties

        public TreeView GraphTree
        {
            get { return ux_GraphTree; }
        }

        private WinFormsSchemaEditorNode SelectedNode
        {
            get { return ux_GraphTree.SelectedNode as WinFormsSchemaEditorNode; }
        }

        #endregion
    }
}
