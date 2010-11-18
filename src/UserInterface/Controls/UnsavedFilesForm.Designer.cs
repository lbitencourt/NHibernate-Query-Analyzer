using System.Windows.Forms;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    partial class UnsavedFilesForm
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
            this.ux_FileList = new System.Windows.Forms.ListView();
            this.ux_FileListFiles = new System.Windows.Forms.ColumnHeader();
            this.ux_Yes = new System.Windows.Forms.Button();
            this.ux_Title = new System.Windows.Forms.Label();
            this.ux_No = new System.Windows.Forms.Button();
            this.ux_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ux_FileList
            // 
            this.ux_FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ux_FileListFiles});
            this.ux_FileList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ux_FileList.FullRowSelect = true;
            this.ux_FileList.GridLines = true;
            this.ux_FileList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ux_FileList.HideSelection = false;
            this.ux_FileList.Location = new System.Drawing.Point(0, 23);
            this.ux_FileList.Name = "ux_FileList";
            this.ux_FileList.Size = new System.Drawing.Size(304, 177);
            this.ux_FileList.TabIndex = 2;
            this.ux_FileList.UseCompatibleStateImageBehavior = false;
            this.ux_FileList.View = System.Windows.Forms.View.Details;
            this.ux_FileList.SelectedIndexChanged += new System.EventHandler(this.ux_FileList_SelectedIndexChanged);
            // 
            // ux_FileListFiles
            // 
            this.ux_FileListFiles.Text = "Files:";
            this.ux_FileListFiles.Width = 300;
            // 
            // ux_Yes
            // 
            this.ux_Yes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ux_Yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.ux_Yes.Enabled = false;
            this.ux_Yes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_Yes.Location = new System.Drawing.Point(8, 216);
            this.ux_Yes.Name = "ux_Yes";
            this.ux_Yes.Size = new System.Drawing.Size(75, 25);
            this.ux_Yes.TabIndex = 0;
            this.ux_Yes.Text = "&Yes";
            this.ux_Yes.Click += new System.EventHandler(this.ux_YesNoCancel_Click);
            // 
            // ux_Title
            // 
            this.ux_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.ux_Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_Title.Location = new System.Drawing.Point(0, 0);
            this.ux_Title.Name = "ux_Title";
            this.ux_Title.Size = new System.Drawing.Size(304, 23);
            this.ux_Title.TabIndex = 1;
            this.ux_Title.Text = "Save changes to the following files?";
            // 
            // ux_No
            // 
            this.ux_No.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ux_No.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ux_No.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_No.Location = new System.Drawing.Point(96, 216);
            this.ux_No.Name = "ux_No";
            this.ux_No.Size = new System.Drawing.Size(75, 25);
            this.ux_No.TabIndex = 3;
            this.ux_No.Text = "&No";
            this.ux_No.Click += new System.EventHandler(this.ux_YesNoCancel_Click);
            // 
            // ux_Cancel
            // 
            this.ux_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ux_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_Cancel.Location = new System.Drawing.Point(224, 216);
            this.ux_Cancel.Name = "ux_Cancel";
            this.ux_Cancel.Size = new System.Drawing.Size(75, 25);
            this.ux_Cancel.TabIndex = 4;
            this.ux_Cancel.Text = "&Cancel";
            this.ux_Cancel.Click += new System.EventHandler(this.ux_YesNoCancel_Click);
            // 
            // UnsavedFilesFormNew
            // 
            this.AcceptButton = this.ux_Yes;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.ux_Cancel;
            this.ClientSize = new System.Drawing.Size(304, 256);
            this.ControlBox = false;
            this.Controls.Add(this.ux_Cancel);
            this.Controls.Add(this.ux_No);
            this.Controls.Add(this.ux_FileList);
            this.Controls.Add(this.ux_Yes);
            this.Controls.Add(this.ux_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnsavedFilesFormNew";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save Files:";
            this.Load += new System.EventHandler(this.UnsavedFilesForm_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.UnsavedFilesForm_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView ux_FileList;
        private ColumnHeader ux_FileListFiles;
        private Button ux_Yes;
        private Button ux_No;
        private Button ux_Cancel;
    }
}