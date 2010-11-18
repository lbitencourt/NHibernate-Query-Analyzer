using System.Windows.Forms;
using Furty.Windows.Forms;
using Netron.Lithium;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface
{
    partial class QueryForm
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
            Netron.Lithium.Impl.ShapeLayout.TreeLayoutStrategy treeLayoutStrategy2 = new Netron.Lithium.Impl.ShapeLayout.TreeLayoutStrategy();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm));
            this.ux_QueryPanel = new System.Windows.Forms.Panel();
            this.ux_EntityExplorerContainer = new System.Windows.Forms.SplitContainer();
            this.ux_EntityExplorer = new System.Windows.Forms.TreeView();
            this.ux_Query = new System.Windows.Forms.TextBox();
            this.ux_ParameterSplitter = new Furty.Windows.Forms.CollapsibleSplitter();
            this.ux_ParametersPanel = new System.Windows.Forms.Panel();
            this.ux_ParametersContainer = new System.Windows.Forms.SplitContainer();
            this.ux_Properties = new System.Windows.Forms.ListView();
            this.ux_PropertyName = new System.Windows.Forms.ColumnHeader();
            this.ux_PropertyType = new System.Windows.Forms.ColumnHeader();
            this.ux_DeleteParameter = new System.Windows.Forms.Button();
            this.ux_QueryParameters = new System.Windows.Forms.ListView();
            this.ux_QueryParametersName = new System.Windows.Forms.ColumnHeader();
            this.ux_QueryParametersType = new System.Windows.Forms.ColumnHeader();
            this.ux_QueryParametersValue = new System.Windows.Forms.ColumnHeader();
            this.ux_ParameterSuggestions = new System.Windows.Forms.ComboBox();
            this.ux_AddParameter = new System.Windows.Forms.Button();
            this.ux_Results = new System.Windows.Forms.TabControl();
            this.ux_ResultsSql = new System.Windows.Forms.TabPage();
            this.ux_SqlQuery = new System.Windows.Forms.TextBox();
            this.ux_ResultsExceptions = new System.Windows.Forms.TabPage();
            this.ux_ExceptionSplitter = new System.Windows.Forms.Splitter();
            this.ux_ExceptionDetail = new System.Windows.Forms.TextBox();
            this.ux_ExceptionsList = new System.Windows.Forms.ListView();
            this.ux_ExceptionsListExceptions = new System.Windows.Forms.ColumnHeader();
            this.ux_ErrorTabSplitter = new System.Windows.Forms.Splitter();
            this.ux_ResultsObjectGraph = new System.Windows.Forms.TabPage();
            this.ux_ObjectGraph = new Netron.Lithium.LithiumControl();
            this.ux_ResultsDatabase = new System.Windows.Forms.TabPage();
            this.ux_DatabaseGrid = new System.Windows.Forms.DataGrid();
            this.ux_ExceptionMessage = new System.Windows.Forms.ColumnHeader();
            this.ux_MainSplitter = new Furty.Windows.Forms.CollapsibleSplitter();
            this.ux_EntitiesImageList = new System.Windows.Forms.ImageList(this.components);
            this.ux_QueryPanel.SuspendLayout();
            this.ux_EntityExplorerContainer.Panel1.SuspendLayout();
            this.ux_EntityExplorerContainer.Panel2.SuspendLayout();
            this.ux_EntityExplorerContainer.SuspendLayout();
            this.ux_ParametersPanel.SuspendLayout();
            this.ux_ParametersContainer.Panel1.SuspendLayout();
            this.ux_ParametersContainer.Panel2.SuspendLayout();
            this.ux_ParametersContainer.SuspendLayout();
            this.ux_Results.SuspendLayout();
            this.ux_ResultsSql.SuspendLayout();
            this.ux_ResultsExceptions.SuspendLayout();
            this.ux_ResultsObjectGraph.SuspendLayout();
            this.ux_ResultsDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ux_DatabaseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_QueryPanel
            // 
            this.ux_QueryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ux_QueryPanel.Controls.Add(this.ux_EntityExplorerContainer);
            this.ux_QueryPanel.Controls.Add(this.ux_ParameterSplitter);
            this.ux_QueryPanel.Controls.Add(this.ux_ParametersPanel);
            this.ux_QueryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ux_QueryPanel.Location = new System.Drawing.Point(0, 0);
            this.ux_QueryPanel.Name = "ux_QueryPanel";
            this.ux_QueryPanel.Size = new System.Drawing.Size(908, 359);
            this.ux_QueryPanel.TabIndex = 1;
            // 
            // ux_EntityExplorerContainer
            // 
            this.ux_EntityExplorerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_EntityExplorerContainer.Location = new System.Drawing.Point(0, 0);
            this.ux_EntityExplorerContainer.Name = "ux_EntityExplorerContainer";
            // 
            // ux_EntityExplorerContainer.Panel1
            // 
            this.ux_EntityExplorerContainer.Panel1.Controls.Add(this.ux_EntityExplorer);
            // 
            // ux_EntityExplorerContainer.Panel2
            // 
            this.ux_EntityExplorerContainer.Panel2.Controls.Add(this.ux_Query);
            this.ux_EntityExplorerContainer.Size = new System.Drawing.Size(606, 357);
            this.ux_EntityExplorerContainer.SplitterDistance = 202;
            this.ux_EntityExplorerContainer.TabIndex = 4;
            // 
            // ux_EntityExplorer
            // 
            this.ux_EntityExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_EntityExplorer.ImageIndex = 4;
            this.ux_EntityExplorer.ImageList = this.ux_EntitiesImageList;
            this.ux_EntityExplorer.Location = new System.Drawing.Point(0, 0);
            this.ux_EntityExplorer.Name = "ux_EntityExplorer";
            this.ux_EntityExplorer.SelectedImageIndex = 3;
            this.ux_EntityExplorer.Size = new System.Drawing.Size(202, 357);
            this.ux_EntityExplorer.TabIndex = 0;
            this.ux_EntityExplorer.DragEnter += new System.Windows.Forms.DragEventHandler(this.ux_EntityExplorer_DragEnter);
            this.ux_EntityExplorer.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ux_EntityExplorer_ItemDrag);
            // 
            // ux_Query
            // 
            this.ux_Query.AllowDrop = true;
            this.ux_Query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_Query.Location = new System.Drawing.Point(0, 0);
            this.ux_Query.Multiline = true;
            this.ux_Query.Name = "ux_Query";
            this.ux_Query.Size = new System.Drawing.Size(400, 357);
            this.ux_Query.TabIndex = 0;
            this.ux_Query.TextChanged += new System.EventHandler(this.ux_Query_TextChanged);
            this.ux_Query.DragDrop += new System.Windows.Forms.DragEventHandler(this.ux_Query_DragDrop);
            this.ux_Query.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ux_Query_KeyDown);
            this.ux_Query.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ux_Query_KeyUp);
            this.ux_Query.DragEnter += new System.Windows.Forms.DragEventHandler(this.ux_Query_DragEnter);
            // 
            // ux_ParameterSplitter
            // 
            this.ux_ParameterSplitter.ControlToHide = this.ux_ParametersPanel;
            this.ux_ParameterSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.ux_ParameterSplitter.ExpandParentForm = false;
            this.ux_ParameterSplitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_ParameterSplitter.Location = new System.Drawing.Point(606, 0);
            this.ux_ParameterSplitter.Name = "ux_ParameterSplitter";
            this.ux_ParameterSplitter.ParentForm = null;
            this.ux_ParameterSplitter.Size = new System.Drawing.Size(8, 357);
            this.ux_ParameterSplitter.TabIndex = 2;
            this.ux_ParameterSplitter.TabStop = false;
            this.ux_ParameterSplitter.VisualStyle = Furty.Windows.Forms.CollapsibleSplitter.VisualStyles.Mozilla;
            // 
            // ux_ParametersPanel
            // 
            this.ux_ParametersPanel.Controls.Add(this.ux_ParametersContainer);
            this.ux_ParametersPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ux_ParametersPanel.Location = new System.Drawing.Point(614, 0);
            this.ux_ParametersPanel.Name = "ux_ParametersPanel";
            this.ux_ParametersPanel.Size = new System.Drawing.Size(292, 357);
            this.ux_ParametersPanel.TabIndex = 3;
            this.ux_ParametersPanel.Visible = false;
            // 
            // ux_ParametersContainer
            // 
            this.ux_ParametersContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_ParametersContainer.Location = new System.Drawing.Point(0, 0);
            this.ux_ParametersContainer.Name = "ux_ParametersContainer";
            this.ux_ParametersContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ux_ParametersContainer.Panel1
            // 
            this.ux_ParametersContainer.Panel1.Controls.Add(this.ux_Properties);
            this.ux_ParametersContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // ux_ParametersContainer.Panel2
            // 
            this.ux_ParametersContainer.Panel2.Controls.Add(this.ux_DeleteParameter);
            this.ux_ParametersContainer.Panel2.Controls.Add(this.ux_QueryParameters);
            this.ux_ParametersContainer.Panel2.Controls.Add(this.ux_ParameterSuggestions);
            this.ux_ParametersContainer.Panel2.Controls.Add(this.ux_AddParameter);
            this.ux_ParametersContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ux_ParametersContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ux_ParametersContainer.Size = new System.Drawing.Size(292, 357);
            this.ux_ParametersContainer.SplitterDistance = 196;
            this.ux_ParametersContainer.TabIndex = 9;
            // 
            // ux_Properties
            // 
            this.ux_Properties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ux_PropertyName,
            this.ux_PropertyType});
            this.ux_Properties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_Properties.FullRowSelect = true;
            this.ux_Properties.GridLines = true;
            this.ux_Properties.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ux_Properties.Location = new System.Drawing.Point(0, 0);
            this.ux_Properties.Name = "ux_Properties";
            this.ux_Properties.Size = new System.Drawing.Size(292, 196);
            this.ux_Properties.TabIndex = 1;
            this.ux_Properties.UseCompatibleStateImageBehavior = false;
            this.ux_Properties.View = System.Windows.Forms.View.Details;
            // 
            // ux_PropertyName
            // 
            this.ux_PropertyName.Text = "Name";
            this.ux_PropertyName.Width = 165;
            // 
            // ux_PropertyType
            // 
            this.ux_PropertyType.Text = "Type";
            this.ux_PropertyType.Width = 120;
            // 
            // ux_DeleteParameter
            // 
            this.ux_DeleteParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_DeleteParameter.Enabled = false;
            this.ux_DeleteParameter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_DeleteParameter.Location = new System.Drawing.Point(257, 12);
            this.ux_DeleteParameter.Name = "ux_DeleteParameter";
            this.ux_DeleteParameter.Size = new System.Drawing.Size(32, 23);
            this.ux_DeleteParameter.TabIndex = 6;
            this.ux_DeleteParameter.Text = "Del";
            this.ux_DeleteParameter.Click += new System.EventHandler(this.ux_DeleteParameter_Click);
            // 
            // ux_QueryParameters
            // 
            this.ux_QueryParameters.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.ux_QueryParameters.AllowColumnReorder = true;
            this.ux_QueryParameters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ux_QueryParametersName,
            this.ux_QueryParametersType,
            this.ux_QueryParametersValue});
            this.ux_QueryParameters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ux_QueryParameters.FullRowSelect = true;
            this.ux_QueryParameters.GridLines = true;
            this.ux_QueryParameters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ux_QueryParameters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_QueryParameters.LabelWrap = false;
            this.ux_QueryParameters.Location = new System.Drawing.Point(0, 39);
            this.ux_QueryParameters.MultiSelect = false;
            this.ux_QueryParameters.Name = "ux_QueryParameters";
            this.ux_QueryParameters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ux_QueryParameters.Size = new System.Drawing.Size(292, 118);
            this.ux_QueryParameters.TabIndex = 0;
            this.ux_QueryParameters.UseCompatibleStateImageBehavior = false;
            this.ux_QueryParameters.View = System.Windows.Forms.View.Details;
            this.ux_QueryParameters.ItemActivate += new System.EventHandler(this.ux_QueryParameters_ItemActivate);
            this.ux_QueryParameters.SelectedIndexChanged += new System.EventHandler(this.ux_QueryParameters_SelectedIndexChanged);
            // 
            // ux_QueryParametersName
            // 
            this.ux_QueryParametersName.Text = "Parameter:";
            this.ux_QueryParametersName.Width = 82;
            // 
            // ux_QueryParametersType
            // 
            this.ux_QueryParametersType.Text = "Type:";
            this.ux_QueryParametersType.Width = 73;
            // 
            // ux_QueryParametersValue
            // 
            this.ux_QueryParametersValue.Text = "Value:";
            this.ux_QueryParametersValue.Width = 70;
            // 
            // ux_ParameterSuggestions
            // 
            this.ux_ParameterSuggestions.ItemHeight = 13;
            this.ux_ParameterSuggestions.Location = new System.Drawing.Point(3, 14);
            this.ux_ParameterSuggestions.Name = "ux_ParameterSuggestions";
            this.ux_ParameterSuggestions.Size = new System.Drawing.Size(205, 21);
            this.ux_ParameterSuggestions.TabIndex = 8;
            // 
            // ux_AddParameter
            // 
            this.ux_AddParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_AddParameter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_AddParameter.Location = new System.Drawing.Point(214, 12);
            this.ux_AddParameter.Name = "ux_AddParameter";
            this.ux_AddParameter.Size = new System.Drawing.Size(40, 23);
            this.ux_AddParameter.TabIndex = 7;
            this.ux_AddParameter.Text = "&Add";
            this.ux_AddParameter.Click += new System.EventHandler(this.ux_AddParameter_Click);
            // 
            // ux_Results
            // 
            this.ux_Results.Controls.Add(this.ux_ResultsSql);
            this.ux_Results.Controls.Add(this.ux_ResultsExceptions);
            this.ux_Results.Controls.Add(this.ux_ResultsObjectGraph);
            this.ux_Results.Controls.Add(this.ux_ResultsDatabase);
            this.ux_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_Results.ItemSize = new System.Drawing.Size(42, 18);
            this.ux_Results.Location = new System.Drawing.Point(0, 367);
            this.ux_Results.Name = "ux_Results";
            this.ux_Results.SelectedIndex = 0;
            this.ux_Results.Size = new System.Drawing.Size(908, 184);
            this.ux_Results.TabIndex = 10;
            // 
            // ux_ResultsSql
            // 
            this.ux_ResultsSql.Controls.Add(this.ux_SqlQuery);
            this.ux_ResultsSql.Location = new System.Drawing.Point(4, 22);
            this.ux_ResultsSql.Name = "ux_ResultsSql";
            this.ux_ResultsSql.Size = new System.Drawing.Size(900, 158);
            this.ux_ResultsSql.TabIndex = 11;
            this.ux_ResultsSql.Text = "SQL:";
            // 
            // ux_SqlQuery
            // 
            this.ux_SqlQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ux_SqlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_SqlQuery.Location = new System.Drawing.Point(0, 0);
            this.ux_SqlQuery.Multiline = true;
            this.ux_SqlQuery.Name = "ux_SqlQuery";
            this.ux_SqlQuery.ReadOnly = true;
            this.ux_SqlQuery.Size = new System.Drawing.Size(900, 158);
            this.ux_SqlQuery.TabIndex = 12;
            // 
            // ux_ResultsExceptions
            // 
            this.ux_ResultsExceptions.Controls.Add(this.ux_ExceptionSplitter);
            this.ux_ResultsExceptions.Controls.Add(this.ux_ExceptionDetail);
            this.ux_ResultsExceptions.Controls.Add(this.ux_ExceptionsList);
            this.ux_ResultsExceptions.Controls.Add(this.ux_ErrorTabSplitter);
            this.ux_ResultsExceptions.Location = new System.Drawing.Point(4, 22);
            this.ux_ResultsExceptions.Name = "ux_ResultsExceptions";
            this.ux_ResultsExceptions.Size = new System.Drawing.Size(900, 158);
            this.ux_ResultsExceptions.TabIndex = 14;
            this.ux_ResultsExceptions.Text = "Exceptions:";
            // 
            // ux_ExceptionSplitter
            // 
            this.ux_ExceptionSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ux_ExceptionSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.ux_ExceptionSplitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_ExceptionSplitter.Location = new System.Drawing.Point(0, 56);
            this.ux_ExceptionSplitter.Name = "ux_ExceptionSplitter";
            this.ux_ExceptionSplitter.Size = new System.Drawing.Size(900, 5);
            this.ux_ExceptionSplitter.TabIndex = 15;
            this.ux_ExceptionSplitter.TabStop = false;
            // 
            // ux_ExceptionDetail
            // 
            this.ux_ExceptionDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_ExceptionDetail.Location = new System.Drawing.Point(0, 56);
            this.ux_ExceptionDetail.Multiline = true;
            this.ux_ExceptionDetail.Name = "ux_ExceptionDetail";
            this.ux_ExceptionDetail.ReadOnly = true;
            this.ux_ExceptionDetail.Size = new System.Drawing.Size(900, 102);
            this.ux_ExceptionDetail.TabIndex = 16;
            // 
            // ux_ExceptionsList
            // 
            this.ux_ExceptionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ux_ExceptionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ux_ExceptionsListExceptions});
            this.ux_ExceptionsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ux_ExceptionsList.FullRowSelect = true;
            this.ux_ExceptionsList.GridLines = true;
            this.ux_ExceptionsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ux_ExceptionsList.Location = new System.Drawing.Point(0, 3);
            this.ux_ExceptionsList.Name = "ux_ExceptionsList";
            this.ux_ExceptionsList.Size = new System.Drawing.Size(900, 53);
            this.ux_ExceptionsList.TabIndex = 17;
            this.ux_ExceptionsList.UseCompatibleStateImageBehavior = false;
            this.ux_ExceptionsList.View = System.Windows.Forms.View.Details;
            this.ux_ExceptionsList.SelectedIndexChanged += new System.EventHandler(this.ux_ExceptionsList_SelectedIndexChanged);
            // 
            // ux_ExceptionsListExceptions
            // 
            this.ux_ExceptionsListExceptions.Text = "Exceptions:";
            this.ux_ExceptionsListExceptions.Width = 600;
            // 
            // ux_ErrorTabSplitter
            // 
            this.ux_ErrorTabSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.ux_ErrorTabSplitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_ErrorTabSplitter.Location = new System.Drawing.Point(0, 0);
            this.ux_ErrorTabSplitter.Name = "ux_ErrorTabSplitter";
            this.ux_ErrorTabSplitter.Size = new System.Drawing.Size(900, 3);
            this.ux_ErrorTabSplitter.TabIndex = 18;
            this.ux_ErrorTabSplitter.TabStop = false;
            // 
            // ux_ResultsObjectGraph
            // 
            this.ux_ResultsObjectGraph.Controls.Add(this.ux_ObjectGraph);
            this.ux_ResultsObjectGraph.Location = new System.Drawing.Point(4, 22);
            this.ux_ResultsObjectGraph.Name = "ux_ResultsObjectGraph";
            this.ux_ResultsObjectGraph.Size = new System.Drawing.Size(900, 158);
            this.ux_ResultsObjectGraph.TabIndex = 19;
            this.ux_ResultsObjectGraph.Text = "Object Graph:";
            // 
            // ux_ObjectGraph
            // 
            this.ux_ObjectGraph.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ux_ObjectGraph.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            this.ux_ObjectGraph.ConnectionLayout = Netron.Lithium.ConnectionLayout.Traditional;
            this.ux_ObjectGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_ObjectGraph.HoverWait = 1500;
            this.ux_ObjectGraph.Location = new System.Drawing.Point(0, 0);
            this.ux_ObjectGraph.Name = "ux_ObjectGraph";
            this.ux_ObjectGraph.SelectedShape = null;
            treeLayoutStrategy2.BranchHeight = 30;
            treeLayoutStrategy2.WordSpacing = 30;
            this.ux_ObjectGraph.ShapeLayoutStrategy = treeLayoutStrategy2;
            this.ux_ObjectGraph.Size = new System.Drawing.Size(900, 158);
            this.ux_ObjectGraph.TabIndex = 20;
            // 
            // ux_ResultsDatabase
            // 
            this.ux_ResultsDatabase.Controls.Add(this.ux_DatabaseGrid);
            this.ux_ResultsDatabase.Location = new System.Drawing.Point(4, 22);
            this.ux_ResultsDatabase.Name = "ux_ResultsDatabase";
            this.ux_ResultsDatabase.Size = new System.Drawing.Size(900, 158);
            this.ux_ResultsDatabase.TabIndex = 21;
            this.ux_ResultsDatabase.Text = "DataBase Results:";
            // 
            // ux_DatabaseGrid
            // 
            this.ux_DatabaseGrid.DataMember = "";
            this.ux_DatabaseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_DatabaseGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.ux_DatabaseGrid.Location = new System.Drawing.Point(0, 0);
            this.ux_DatabaseGrid.Name = "ux_DatabaseGrid";
            this.ux_DatabaseGrid.ReadOnly = true;
            this.ux_DatabaseGrid.Size = new System.Drawing.Size(900, 158);
            this.ux_DatabaseGrid.TabIndex = 22;
            // 
            // ux_ExceptionMessage
            // 
            this.ux_ExceptionMessage.Text = "ColumnHeader";
            this.ux_ExceptionMessage.Width = 812;
            // 
            // ux_MainSplitter
            // 
            this.ux_MainSplitter.ControlToHide = this.ux_QueryPanel;
            this.ux_MainSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.ux_MainSplitter.ExpandParentForm = false;
            this.ux_MainSplitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_MainSplitter.Location = new System.Drawing.Point(0, 359);
            this.ux_MainSplitter.Name = "ux_MainSplitter";
            this.ux_MainSplitter.ParentForm = null;
            this.ux_MainSplitter.Size = new System.Drawing.Size(908, 8);
            this.ux_MainSplitter.TabIndex = 23;
            this.ux_MainSplitter.TabStop = false;
            this.ux_MainSplitter.VisualStyle = Furty.Windows.Forms.CollapsibleSplitter.VisualStyles.Mozilla;
            // 
            // ux_EntitiesImageList
            // 
            this.ux_EntitiesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ux_EntitiesImageList.ImageStream")));
            this.ux_EntitiesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ux_EntitiesImageList.Images.SetKeyName(0, "");
            this.ux_EntitiesImageList.Images.SetKeyName(1, "");
            this.ux_EntitiesImageList.Images.SetKeyName(2, "bug.png");
            this.ux_EntitiesImageList.Images.SetKeyName(3, "file.png");
            this.ux_EntitiesImageList.Images.SetKeyName(4, "folder.png");
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(908, 551);
            this.Controls.Add(this.ux_Results);
            this.Controls.Add(this.ux_MainSplitter);
            this.Controls.Add(this.ux_QueryPanel);
            this.Name = "QueryForm";
            this.TabText = "Query";
            this.Text = "Query";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.ux_QueryPanel.ResumeLayout(false);
            this.ux_EntityExplorerContainer.Panel1.ResumeLayout(false);
            this.ux_EntityExplorerContainer.Panel2.ResumeLayout(false);
            this.ux_EntityExplorerContainer.Panel2.PerformLayout();
            this.ux_EntityExplorerContainer.ResumeLayout(false);
            this.ux_ParametersPanel.ResumeLayout(false);
            this.ux_ParametersContainer.Panel1.ResumeLayout(false);
            this.ux_ParametersContainer.Panel2.ResumeLayout(false);
            this.ux_ParametersContainer.ResumeLayout(false);
            this.ux_Results.ResumeLayout(false);
            this.ux_ResultsSql.ResumeLayout(false);
            this.ux_ResultsSql.PerformLayout();
            this.ux_ResultsExceptions.ResumeLayout(false);
            this.ux_ResultsExceptions.PerformLayout();
            this.ux_ResultsObjectGraph.ResumeLayout(false);
            this.ux_ResultsDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ux_DatabaseGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ux_QueryPanel;
        private TextBox ux_Query;
        private CollapsibleSplitter ux_ParameterSplitter;
        private TabControl ux_Results;
        private TabPage ux_ResultsSql;
        private TextBox ux_SqlQuery;
        private TabPage ux_ResultsExceptions;
        private Splitter ux_ErrorTabSplitter;
        private TextBox ux_ExceptionDetail;
        private ColumnHeader ux_ExceptionMessage;
        private CollapsibleSplitter ux_MainSplitter;
        private Panel ux_ParametersPanel;
        private ListView ux_QueryParameters;
        private ColumnHeader ux_QueryParametersName;
        private ColumnHeader ux_QueryParametersType;
        private ColumnHeader ux_QueryParametersValue;
        private ComboBox ux_ParameterSuggestions;
        private Button ux_AddParameter;
        private Button ux_DeleteParameter;
        private ListView ux_ExceptionsList;
        private ColumnHeader ux_ExceptionsListExceptions;
        private Splitter ux_ExceptionSplitter;
        private TabPage ux_ResultsObjectGraph;
        private LithiumControl ux_ObjectGraph;
        private TabPage ux_ResultsDatabase;
        private DataGrid ux_DatabaseGrid;
        private SplitContainer ux_EntityExplorerContainer;
        private TreeView ux_EntityExplorer;
        private SplitContainer ux_ParametersContainer;
        private ListView ux_Properties;
        private ColumnHeader ux_PropertyName;
        private ColumnHeader ux_PropertyType;
        private ImageList ux_EntitiesImageList;
    }
}