using System.Windows.Forms;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface
{
    partial class ProjectView
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

            presenter.ProjectViewDisposed();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ux_FileList = new System.Windows.Forms.ListView();
            this.ux_FileName = new System.Windows.Forms.ColumnHeader();
            this.ux_FilePath = new System.Windows.Forms.ColumnHeader();
            this.ux_AddFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.ux_BottomPanel = new System.Windows.Forms.Panel();
            this.ux_EditProject = new System.Windows.Forms.Button();
            this.ux_BuildProject = new System.Windows.Forms.Button();
            this.ux_RemoveFile = new System.Windows.Forms.Button();
            this.ux_AddFile = new System.Windows.Forms.Button();
            this.ux_BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ux_FileList
            // 
            this.ux_FileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ux_FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ux_FileName,
            this.ux_FilePath});
            this.ux_FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_FileList.FullRowSelect = true;
            this.ux_FileList.GridLines = true;
            this.ux_FileList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ux_FileList.Location = new System.Drawing.Point(0, 0);
            this.ux_FileList.MultiSelect = false;
            this.ux_FileList.Name = "ux_FileList";
            this.ux_FileList.Size = new System.Drawing.Size(624, 278);
            this.ux_FileList.TabIndex = 0;
            this.ux_FileList.UseCompatibleStateImageBehavior = false;
            this.ux_FileList.View = System.Windows.Forms.View.Details;
            this.ux_FileList.SelectedIndexChanged += new System.EventHandler(this.ux_FileList_SelectedIndexChanged);
            // 
            // ux_FileName
            // 
            this.ux_FileName.Text = "File Name:";
            this.ux_FileName.Width = 150;
            // 
            // ux_FilePath
            // 
            this.ux_FilePath.Text = "Path";
            this.ux_FilePath.Width = 350;
            // 
            // ux_AddFilesDialog
            // 
            this.ux_AddFilesDialog.Filter = "All Supported Files | *.hbm.xml; *.cfg.xml; *.exe; *.dll; *.config; ";
            this.ux_AddFilesDialog.Multiselect = true;
            this.ux_AddFilesDialog.Title = "Add File(s)...";
            // 
            // ux_BottomPanel
            // 
            this.ux_BottomPanel.Controls.Add(this.ux_EditProject);
            this.ux_BottomPanel.Controls.Add(this.ux_BuildProject);
            this.ux_BottomPanel.Controls.Add(this.ux_RemoveFile);
            this.ux_BottomPanel.Controls.Add(this.ux_AddFile);
            this.ux_BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ux_BottomPanel.Location = new System.Drawing.Point(0, 278);
            this.ux_BottomPanel.Name = "ux_BottomPanel";
            this.ux_BottomPanel.Size = new System.Drawing.Size(624, 48);
            this.ux_BottomPanel.TabIndex = 1;
            // 
            // ux_EditProject
            // 
            this.ux_EditProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_EditProject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_EditProject.Location = new System.Drawing.Point(416, 12);
            this.ux_EditProject.Name = "ux_EditProject";
            this.ux_EditProject.Size = new System.Drawing.Size(88, 23);
            this.ux_EditProject.TabIndex = 14;
            this.ux_EditProject.Text = "Edit Project";
            this.ux_EditProject.Visible = false;
            this.ux_EditProject.Click += new System.EventHandler(this.ux_EditProject_Click);
            // 
            // ux_BuildProject
            // 
            this.ux_BuildProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_BuildProject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_BuildProject.Location = new System.Drawing.Point(520, 12);
            this.ux_BuildProject.Name = "ux_BuildProject";
            this.ux_BuildProject.Size = new System.Drawing.Size(88, 23);
            this.ux_BuildProject.TabIndex = 13;
            this.ux_BuildProject.Text = "&Build Project";
            this.ux_BuildProject.Click += new System.EventHandler(this.ux_BuildProject_Click);
            // 
            // ux_RemoveFile
            // 
            this.ux_RemoveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ux_RemoveFile.Enabled = false;
            this.ux_RemoveFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_RemoveFile.Location = new System.Drawing.Point(136, 12);
            this.ux_RemoveFile.Name = "ux_RemoveFile";
            this.ux_RemoveFile.Size = new System.Drawing.Size(120, 23);
            this.ux_RemoveFile.TabIndex = 12;
            this.ux_RemoveFile.Text = "&Remove File";
            this.ux_RemoveFile.Click += new System.EventHandler(this.ux_RemoveFile_Click);
            // 
            // ux_AddFile
            // 
            this.ux_AddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ux_AddFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_AddFile.Location = new System.Drawing.Point(16, 12);
            this.ux_AddFile.Name = "ux_AddFile";
            this.ux_AddFile.Size = new System.Drawing.Size(104, 23);
            this.ux_AddFile.TabIndex = 11;
            this.ux_AddFile.Text = "&Add File(s)...";
            this.ux_AddFile.Click += new System.EventHandler(this.ux_AddFile_Click);
            // 
            // ProjectView
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(624, 326);
            this.Controls.Add(this.ux_FileList);
            this.Controls.Add(this.ux_BottomPanel);
            this.Name = "ProjectView";
            this.Text = "Configuration";
            this.Title = "Configuration";
            this.ux_BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView ux_FileList;
        private ColumnHeader ux_FileName;
        private ColumnHeader ux_FilePath;
        private OpenFileDialog ux_AddFilesDialog;
        private Panel ux_BottomPanel;
        private Button ux_EditProject;
        private Button ux_BuildProject;
        private Button ux_RemoveFile;
        private Button ux_AddFile;
    }
}