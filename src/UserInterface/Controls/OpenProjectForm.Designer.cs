using System.Windows.Forms;
using MenuItem=System.Windows.Forms.MenuItem;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    partial class OpenProjectForm
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
            this.ux_ProjectList = new System.Windows.Forms.ListView();
            this.ux_ProjectListName = new System.Windows.Forms.ColumnHeader();
            this.ux_ProjectListId = new System.Windows.Forms.ColumnHeader();
            this.ux_ContextMenu = new System.Windows.Forms.ContextMenu();
            this.ux_ContextMenuDeleteProject = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // ux_ProjectList
            // 
            this.ux_ProjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_ProjectList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ux_ProjectListName,
            this.ux_ProjectListId});
            this.ux_ProjectList.ContextMenu = this.ux_ContextMenu;
            this.ux_ProjectList.FullRowSelect = true;
            this.ux_ProjectList.GridLines = true;
            this.ux_ProjectList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ux_ProjectList.HideSelection = false;
            this.ux_ProjectList.Location = new System.Drawing.Point(8, 8);
            this.ux_ProjectList.MultiSelect = false;
            this.ux_ProjectList.Name = "ux_ProjectList";
            this.ux_ProjectList.Size = new System.Drawing.Size(320, 266);
            this.ux_ProjectList.TabIndex = 0;
            this.ux_ProjectList.UseCompatibleStateImageBehavior = false;
            this.ux_ProjectList.View = System.Windows.Forms.View.Details;
            this.ux_ProjectList.ItemActivate += new System.EventHandler(this.ux_ProjectList_ItemActivate);
            this.ux_ProjectList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ux_ProjectList_KeyDown);
            // 
            // ux_ProjectListName
            // 
            this.ux_ProjectListName.Text = "Name:";
            this.ux_ProjectListName.Width = 250;
            // 
            // ux_ProjectListId
            // 
            this.ux_ProjectListId.Text = "ID:";
            // 
            // ux_ContextMenu
            // 
            this.ux_ContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ux_ContextMenuDeleteProject});
            this.ux_ContextMenu.Popup += new System.EventHandler(this.ux_ContextMenu_Popup);
            // 
            // ux_ContextMenuDeleteProject
            // 
            this.ux_ContextMenuDeleteProject.Index = 0;
            this.ux_ContextMenuDeleteProject.Text = "&Delete Project";
            this.ux_ContextMenuDeleteProject.Click += new System.EventHandler(this.ux_ContextMenuDeleteProject_Click);
            // 
            // OpenProjectForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(338, 280);
            this.Controls.Add(this.ux_ProjectList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenProjectForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open Project";
            this.Load += new System.EventHandler(this.OpenProjectForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpenProjectForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private ColumnHeader ux_ProjectListName;
        private ColumnHeader ux_ProjectListId;
        private ListView ux_ProjectList;
        private ContextMenu ux_ContextMenu;
        private MenuItem ux_ContextMenuDeleteProject;
    }
}