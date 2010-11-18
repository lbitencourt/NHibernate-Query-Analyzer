using System;
using System.Windows.Forms;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Controls;
using Furty.Windows.Forms;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface
{
    partial class SchemaEditorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchemaEditorView));
            this.ux_DocumentTabs = new System.Windows.Forms.TabControl();
            this.ux_DocumentGraphTab = new System.Windows.Forms.TabPage();
            this.ux_AttributePropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.ux_HorizontalSplitter = new Furty.Windows.Forms.CollapsibleSplitter();
            this.ux_ErrorList = new System.Windows.Forms.ListView();
            this.ux_ErrorListSchemaErrors = new System.Windows.Forms.ColumnHeader();
            this.ux_VerticalSplitter = new System.Windows.Forms.Splitter();
            this.ux_GraphTree = new Ayende.NHibernateQueryAnalyzer.UserInterface.Controls.ContextMenuTreeView();
            this.ux_GraphTreeContextMenu = new System.Windows.Forms.ContextMenu();
            this.ux_GraphTreeContextMenuAdd = new System.Windows.Forms.MenuItem();
            this.ux_GraphTreeContextMenuAddNothing = new System.Windows.Forms.MenuItem();
            this.ux_GraphTreeContextMenuSplitter = new System.Windows.Forms.MenuItem();
            this.ux_GraphTreeContextMenuRemove = new System.Windows.Forms.MenuItem();
            this.ux_Images = new System.Windows.Forms.ImageList(this.components);
            this.ux_DocumentXmlTab = new System.Windows.Forms.TabPage();
            this.ux_Xml = new System.Windows.Forms.TextBox();
            this.ux_ErrorTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ux_DocumentTabs.SuspendLayout();
            this.ux_DocumentGraphTab.SuspendLayout();
            this.ux_DocumentXmlTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ux_DocumentTabs
            // 
            this.ux_DocumentTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.ux_DocumentTabs.Controls.Add(this.ux_DocumentGraphTab);
            this.ux_DocumentTabs.Controls.Add(this.ux_DocumentXmlTab);
            this.ux_DocumentTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_DocumentTabs.Location = new System.Drawing.Point(0, 0);
            this.ux_DocumentTabs.Name = "ux_DocumentTabs";
            this.ux_DocumentTabs.SelectedIndex = 0;
            this.ux_DocumentTabs.Size = new System.Drawing.Size(792, 494);
            this.ux_DocumentTabs.TabIndex = 0;
            this.ux_DocumentTabs.SelectedIndexChanged += new EventHandler(this.ux_DocumentTabs_SelectedIndexChanged);
            // 
            // ux_DocumentGraphTab
            // 
            this.ux_DocumentGraphTab.Controls.Add(this.ux_AttributePropertyGrid);
            this.ux_DocumentGraphTab.Controls.Add(this.ux_HorizontalSplitter);
            this.ux_DocumentGraphTab.Controls.Add(this.ux_ErrorList);
            this.ux_DocumentGraphTab.Controls.Add(this.ux_VerticalSplitter);
            this.ux_DocumentGraphTab.Controls.Add(this.ux_GraphTree);
            this.ux_DocumentGraphTab.Location = new System.Drawing.Point(4, 4);
            this.ux_DocumentGraphTab.Name = "ux_DocumentGraphTab";
            this.ux_DocumentGraphTab.Size = new System.Drawing.Size(784, 468);
            this.ux_DocumentGraphTab.TabIndex = 0;
            this.ux_DocumentGraphTab.Text = "Graph View";
            this.ux_DocumentGraphTab.UseVisualStyleBackColor = true;
            // 
            // ux_AttributePropertyGrid
            // 
            this.ux_AttributePropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_AttributePropertyGrid.Location = new System.Drawing.Point(179, 0);
            this.ux_AttributePropertyGrid.Name = "ux_AttributePropertyGrid";
            this.ux_AttributePropertyGrid.Size = new System.Drawing.Size(605, 385);
            this.ux_AttributePropertyGrid.TabIndex = 8;
            this.ux_AttributePropertyGrid.PropertyValueChanged += new PropertyValueChangedEventHandler(this.ux_AttributePropertyGrid_PropertyValueChanged);
            // 
            // ux_HorizontalSplitter
            // 
            this.ux_HorizontalSplitter.ControlToHide = this.ux_ErrorList;
            this.ux_HorizontalSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ux_HorizontalSplitter.ExpandParentForm = false;
            this.ux_HorizontalSplitter.Location = new System.Drawing.Point(179, 385);
            this.ux_HorizontalSplitter.Name = "ux_HorizontalSplitter";
            this.ux_HorizontalSplitter.ParentForm = null;
            this.ux_HorizontalSplitter.Size = new System.Drawing.Size(605, 8);
            this.ux_HorizontalSplitter.TabIndex = 7;
            this.ux_HorizontalSplitter.TabStop = false;
            this.ux_HorizontalSplitter.VisualStyle = Furty.Windows.Forms.CollapsibleSplitter.VisualStyles.Mozilla;
            // 
            // ux_ErrorList
            // 
            this.ux_ErrorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ux_ErrorListSchemaErrors});
            this.ux_ErrorList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ux_ErrorList.ForeColor = System.Drawing.Color.Maroon;
            this.ux_ErrorList.FullRowSelect = true;
            this.ux_ErrorList.GridLines = true;
            this.ux_ErrorList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ux_ErrorList.Location = new System.Drawing.Point(179, 393);
            this.ux_ErrorList.MultiSelect = false;
            this.ux_ErrorList.Name = "ux_ErrorList";
            this.ux_ErrorList.Size = new System.Drawing.Size(605, 75);
            this.ux_ErrorList.TabIndex = 6;
            this.ux_ErrorList.UseCompatibleStateImageBehavior = false;
            this.ux_ErrorList.View = System.Windows.Forms.View.Details;
            this.ux_ErrorList.Visible = false;
            // 
            // ux_ErrorListSchemaErrors
            // 
            this.ux_ErrorListSchemaErrors.Text = "Schema Errors:";
            this.ux_ErrorListSchemaErrors.Width = 592;
            // 
            // ux_VerticalSplitter
            // 
            this.ux_VerticalSplitter.Location = new System.Drawing.Point(176, 0);
            this.ux_VerticalSplitter.Name = "ux_VerticalSplitter";
            this.ux_VerticalSplitter.Size = new System.Drawing.Size(3, 468);
            this.ux_VerticalSplitter.TabIndex = 1;
            this.ux_VerticalSplitter.TabStop = false;
            // 
            // ux_GraphTree
            // 
            this.ux_GraphTree.ContextMenu = this.ux_GraphTreeContextMenu;
            this.ux_GraphTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.ux_GraphTree.FullRowSelect = true;
            this.ux_GraphTree.HideSelection = false;
            this.ux_GraphTree.ImageIndex = 0;
            this.ux_GraphTree.ImageList = this.ux_Images;
            this.ux_GraphTree.Location = new System.Drawing.Point(0, 0);
            this.ux_GraphTree.Name = "ux_GraphTree";
            this.ux_GraphTree.SelectedImageIndex = 0;
            this.ux_GraphTree.Size = new System.Drawing.Size(176, 468);
            this.ux_GraphTree.TabIndex = 0;
            this.ux_GraphTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ux_GraphTree_AfterSelect);
            this.ux_GraphTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ux_GraphTree_MouseDown);
            this.ux_GraphTree.MouseHover += new System.EventHandler(this.ux_GraphTree_MouseHover);
            // 
            // ux_GraphTreeContextMenu
            // 
            this.ux_GraphTreeContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ux_GraphTreeContextMenuAdd,
            this.ux_GraphTreeContextMenuSplitter,
            this.ux_GraphTreeContextMenuRemove});
            this.ux_GraphTreeContextMenu.Popup += new System.EventHandler(this.ux_GraphTreeContextMenu_Popup);
            // 
            // ux_GraphTreeContextMenuAdd
            // 
            this.ux_GraphTreeContextMenuAdd.Index = 0;
            this.ux_GraphTreeContextMenuAdd.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ux_GraphTreeContextMenuAddNothing});
            this.ux_GraphTreeContextMenuAdd.Text = "&Add";
            this.ux_GraphTreeContextMenuAdd.Popup += new System.EventHandler(this.ux_GraphTreeContextMenuAdd_Popup);
            // 
            // ux_GraphTreeContextMenuAddNothing
            // 
            this.ux_GraphTreeContextMenuAddNothing.Enabled = false;
            this.ux_GraphTreeContextMenuAddNothing.Index = 0;
            this.ux_GraphTreeContextMenuAddNothing.Text = "Nothing to add";
            // 
            // ux_GraphTreeContextMenuSplitter
            // 
            this.ux_GraphTreeContextMenuSplitter.Index = 1;
            this.ux_GraphTreeContextMenuSplitter.Text = "-";
            // 
            // ux_GraphTreeContextMenuRemove
            // 
            this.ux_GraphTreeContextMenuRemove.Index = 2;
            this.ux_GraphTreeContextMenuRemove.Text = "&Remove";
            this.ux_GraphTreeContextMenuRemove.Click += new System.EventHandler(this.ux_GraphTreeContextMenuRemove_Click);
            // 
            // ux_Images
            // 
            this.ux_Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ux_Images.ImageStream")));
            this.ux_Images.TransparentColor = System.Drawing.Color.Transparent;
            this.ux_Images.Images.SetKeyName(0, "");
            this.ux_Images.Images.SetKeyName(1, "");
            this.ux_Images.Images.SetKeyName(2, "");
            // 
            // ux_DocumentXmlTab
            // 
            this.ux_DocumentXmlTab.Controls.Add(this.ux_Xml);
            this.ux_DocumentXmlTab.Location = new System.Drawing.Point(4, 4);
            this.ux_DocumentXmlTab.Name = "ux_DocumentXmlTab";
            this.ux_DocumentXmlTab.Size = new System.Drawing.Size(784, 468);
            this.ux_DocumentXmlTab.TabIndex = 1;
            this.ux_DocumentXmlTab.Text = "Xml";
            this.ux_DocumentXmlTab.UseVisualStyleBackColor = true;
            this.ux_DocumentXmlTab.Validating += new System.ComponentModel.CancelEventHandler(this.ux_DocumentXmlTab_Validating);
            // 
            // ux_Xml
            // 
            this.ux_Xml.AcceptsReturn = true;
            this.ux_Xml.AcceptsTab = true;
            this.ux_Xml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_Xml.Location = new System.Drawing.Point(0, 0);
            this.ux_Xml.Multiline = true;
            this.ux_Xml.Name = "ux_Xml";
            this.ux_Xml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ux_Xml.Size = new System.Drawing.Size(784, 468);
            this.ux_Xml.TabIndex = 0;
            this.ux_Xml.TextChanged += new System.EventHandler(this.ux_Xml_TextChanged);
            // 
            // SchemaEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(792, 494);
            this.Controls.Add(this.ux_DocumentTabs);
            this.Name = "SchemaEditorView";
            this.TabText = "SchemaEditorView";
            this.Text = "SchemaEditorView";
            this.ux_DocumentTabs.ResumeLayout(false);
            this.ux_DocumentGraphTab.ResumeLayout(false);
            this.ux_DocumentXmlTab.ResumeLayout(false);
            this.ux_DocumentXmlTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl ux_DocumentTabs;
        private TabPage ux_DocumentGraphTab;
        private TabPage ux_DocumentXmlTab;
        private ContextMenuTreeView ux_GraphTree;
        private Splitter ux_VerticalSplitter;
        private TextBox ux_Xml;
        private ImageList ux_Images;
        private ContextMenu ux_GraphTreeContextMenu;
        private MenuItem ux_GraphTreeContextMenuAdd;
        private MenuItem ux_GraphTreeContextMenuRemove;
        private MenuItem ux_GraphTreeContextMenuAddNothing;
        private MenuItem ux_GraphTreeContextMenuSplitter;
        private ToolTip ux_ErrorTooltip;
        private ListView ux_ErrorList;
        private ColumnHeader ux_ErrorListSchemaErrors;
        private CollapsibleSplitter ux_HorizontalSplitter;
        private PropertyGrid ux_AttributePropertyGrid;

    }
}