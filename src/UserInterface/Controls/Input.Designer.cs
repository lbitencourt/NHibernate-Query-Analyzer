using System.Windows.Forms;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    partial class Input
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
            this.ux_Question = new System.Windows.Forms.Label();
            this.ux_Cancel = new System.Windows.Forms.Button();
            this.ux_Ok = new System.Windows.Forms.Button();
            this.ux_Answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ux_Question
            // 
            this.ux_Question.Dock = System.Windows.Forms.DockStyle.Top;
            this.ux_Question.Location = new System.Drawing.Point(0, 0);
            this.ux_Question.Name = "ux_Question";
            this.ux_Question.Size = new System.Drawing.Size(384, 24);
            this.ux_Question.TabIndex = 0;
            // 
            // ux_Cancel
            // 
            this.ux_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ux_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_Cancel.Location = new System.Drawing.Point(296, 50);
            this.ux_Cancel.Name = "ux_Cancel";
            this.ux_Cancel.Size = new System.Drawing.Size(75, 29);
            this.ux_Cancel.TabIndex = 7;
            this.ux_Cancel.Text = "Cancel";
            // 
            // ux_Ok
            // 
            this.ux_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ux_Ok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_Ok.Location = new System.Drawing.Point(16, 50);
            this.ux_Ok.Name = "ux_Ok";
            this.ux_Ok.Size = new System.Drawing.Size(75, 29);
            this.ux_Ok.TabIndex = 5;
            this.ux_Ok.Text = "Ok";
            // 
            // ux_Answer
            // 
            this.ux_Answer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ux_Answer.Location = new System.Drawing.Point(0, 24);
            this.ux_Answer.Name = "ux_Answer";
            this.ux_Answer.Size = new System.Drawing.Size(384, 20);
            this.ux_Answer.TabIndex = 8;
            // 
            // InputNew
            // 
            this.AcceptButton = this.ux_Ok;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.ux_Cancel;
            this.ClientSize = new System.Drawing.Size(384, 88);
            this.ControlBox = false;
            this.Controls.Add(this.ux_Answer);
            this.Controls.Add(this.ux_Cancel);
            this.Controls.Add(this.ux_Ok);
            this.Controls.Add(this.ux_Question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputNew";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Please Answer:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ux_Question;
        private Button ux_Cancel;
        private Button ux_Ok;
        private TextBox ux_Answer;
    }
}