using System.Windows.Forms;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    partial class OpenQueryForm
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
            this.ux_QueriesPanel = new System.Windows.Forms.Panel();
            this.ux_QueryText = new System.Windows.Forms.TextBox();
            this.ux_VerticalSplitter = new System.Windows.Forms.Splitter();
            this.ux_QueryList = new System.Windows.Forms.ListBox();
            this.ux_Cancel = new System.Windows.Forms.Button();
            this.ux_Ok = new System.Windows.Forms.Button();
            this.ux_QueriesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ux_QueriesPanel
            // 
            this.ux_QueriesPanel.Controls.Add(this.ux_QueryText);
            this.ux_QueriesPanel.Controls.Add(this.ux_VerticalSplitter);
            this.ux_QueriesPanel.Controls.Add(this.ux_QueryList);
            this.ux_QueriesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ux_QueriesPanel.Location = new System.Drawing.Point(0, 0);
            this.ux_QueriesPanel.Name = "ux_QueriesPanel";
            this.ux_QueriesPanel.Size = new System.Drawing.Size(400, 216);
            this.ux_QueriesPanel.TabIndex = 0;
            // 
            // ux_QueryText
            // 
            this.ux_QueryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_QueryText.Location = new System.Drawing.Point(123, 0);
            this.ux_QueryText.Multiline = true;
            this.ux_QueryText.Name = "ux_QueryText";
            this.ux_QueryText.ReadOnly = true;
            this.ux_QueryText.Size = new System.Drawing.Size(277, 216);
            this.ux_QueryText.TabIndex = 5;
            // 
            // ux_VerticalSplitter
            // 
            this.ux_VerticalSplitter.Location = new System.Drawing.Point(120, 0);
            this.ux_VerticalSplitter.Name = "ux_VerticalSplitter";
            this.ux_VerticalSplitter.Size = new System.Drawing.Size(3, 216);
            this.ux_VerticalSplitter.TabIndex = 4;
            this.ux_VerticalSplitter.TabStop = false;
            // 
            // ux_QueryList
            // 
            this.ux_QueryList.Dock = System.Windows.Forms.DockStyle.Left;
            this.ux_QueryList.Location = new System.Drawing.Point(0, 0);
            this.ux_QueryList.Name = "ux_QueryList";
            this.ux_QueryList.Size = new System.Drawing.Size(120, 212);
            this.ux_QueryList.TabIndex = 3;
            this.ux_QueryList.SelectedIndexChanged += new System.EventHandler(this.queryList_SelectedIndexChanged);
            this.ux_QueryList.DoubleClick += new System.EventHandler(this.ux_QueryList_DoubleClick);
            // 
            // ux_Cancel
            // 
            this.ux_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ux_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_Cancel.Location = new System.Drawing.Point(312, 224);
            this.ux_Cancel.Name = "ux_Cancel";
            this.ux_Cancel.Size = new System.Drawing.Size(75, 25);
            this.ux_Cancel.TabIndex = 11;
            this.ux_Cancel.Text = "&Cancel";
            this.ux_Cancel.Click += new System.EventHandler(this.ux_Cancel_Click);
            // 
            // ux_Ok
            // 
            this.ux_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ux_Ok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_Ok.Location = new System.Drawing.Point(16, 224);
            this.ux_Ok.Name = "ux_Ok";
            this.ux_Ok.Size = new System.Drawing.Size(75, 25);
            this.ux_Ok.TabIndex = 9;
            this.ux_Ok.Text = "&Ok";
            this.ux_Ok.Click += new System.EventHandler(this.ux_Ok_Click);
            // 
            // OpenQueryFormNew
            // 
            this.AcceptButton = this.ux_Ok;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.ux_Cancel;
            this.ClientSize = new System.Drawing.Size(400, 254);
            this.Controls.Add(this.ux_Cancel);
            this.Controls.Add(this.ux_Ok);
            this.Controls.Add(this.ux_QueriesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenQueryFormNew";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open Query";
            this.ux_QueriesPanel.ResumeLayout(false);
            this.ux_QueriesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ux_QueriesPanel;
        private TextBox ux_QueryText;
        private Splitter ux_VerticalSplitter;
        private ListBox ux_QueryList;
        private Button ux_Cancel;
        private Button ux_Ok;
    }
}