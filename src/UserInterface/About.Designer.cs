using System.Windows.Forms;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface
{
    partial class About
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
            this.ux_Close = new System.Windows.Forms.Button();
            this.ux_NqaLogo = new System.Windows.Forms.PictureBox();
            this.ux_NqaHomepage = new System.Windows.Forms.LinkLabel();
            this.ux_NHibernateHomepage = new System.Windows.Forms.LinkLabel();
            this.ux_ReportBug = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ux_NqaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_Close
            // 
            this.ux_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ux_Close.Location = new System.Drawing.Point(320, 392);
            this.ux_Close.Name = "ux_Close";
            this.ux_Close.Size = new System.Drawing.Size(75, 23);
            this.ux_Close.TabIndex = 0;
            this.ux_Close.Text = "Close";
            this.ux_Close.Click += new System.EventHandler(this.ux_Close_Click);
            // 
            // ux_NqaLogo
            // 
            this.ux_NqaLogo.Image = global::Ayende.NHibernateQueryAnalyzer.UserInterface.Properties.Resources.NqaLogo;
            this.ux_NqaLogo.Location = new System.Drawing.Point(8, 8);
            this.ux_NqaLogo.Name = "ux_NqaLogo";
            this.ux_NqaLogo.Size = new System.Drawing.Size(400, 416);
            this.ux_NqaLogo.TabIndex = 1;
            this.ux_NqaLogo.TabStop = false;
            // 
            // ux_NqaHomepage
            // 
            this.ux_NqaHomepage.Location = new System.Drawing.Point(8, 16);
            this.ux_NqaHomepage.Name = "ux_NqaHomepage";
            this.ux_NqaHomepage.Size = new System.Drawing.Size(112, 32);
            this.ux_NqaHomepage.TabIndex = 2;
            this.ux_NqaHomepage.TabStop = true;
            this.ux_NqaHomepage.Text = "NHibernate Query Analyzer Homepage";
            this.ux_NqaHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ux_NqaHomepage_LinkClicked);
            // 
            // ux_NHibernateHomepage
            // 
            this.ux_NHibernateHomepage.Location = new System.Drawing.Point(8, 384);
            this.ux_NHibernateHomepage.Name = "ux_NHibernateHomepage";
            this.ux_NHibernateHomepage.Size = new System.Drawing.Size(120, 24);
            this.ux_NHibernateHomepage.TabIndex = 3;
            this.ux_NHibernateHomepage.TabStop = true;
            this.ux_NHibernateHomepage.Text = "NHibernate Homepage";
            this.ux_NHibernateHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ux_NHibernateHomepage_LinkClicked);
            // 
            // ux_ReportBug
            // 
            this.ux_ReportBug.Location = new System.Drawing.Point(320, 16);
            this.ux_ReportBug.Name = "ux_ReportBug";
            this.ux_ReportBug.Size = new System.Drawing.Size(72, 24);
            this.ux_ReportBug.TabIndex = 4;
            this.ux_ReportBug.TabStop = true;
            this.ux_ReportBug.Text = "Report a bug";
            this.ux_ReportBug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ux_ReportBug_LinkClicked);
            // 
            // About
            // 
            this.AcceptButton = this.ux_Close;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.ux_Close;
            this.ClientSize = new System.Drawing.Size(408, 424);
            this.ControlBox = false;
            this.Controls.Add(this.ux_ReportBug);
            this.Controls.Add(this.ux_NHibernateHomepage);
            this.Controls.Add(this.ux_NqaHomepage);
            this.Controls.Add(this.ux_Close);
            this.Controls.Add(this.ux_NqaLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About NHiberante Query Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.ux_NqaLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ux_Close;
        private PictureBox ux_NqaLogo;
        private LinkLabel ux_NqaHomepage;
        private LinkLabel ux_NHibernateHomepage;
        private LinkLabel ux_ReportBug;
    }
}