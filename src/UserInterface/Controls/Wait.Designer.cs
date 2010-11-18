using System.Windows.Forms;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    partial class Wait
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
            this.ux_WaitText = new System.Windows.Forms.Label();
            this.ux_Timer = new System.Windows.Forms.Timer(this.components);
            this.ux_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ux_WaitText
            // 
            this.ux_WaitText.Dock = System.Windows.Forms.DockStyle.Top;
            this.ux_WaitText.Location = new System.Drawing.Point(0, 0);
            this.ux_WaitText.Name = "ux_WaitText";
            this.ux_WaitText.Size = new System.Drawing.Size(384, 32);
            this.ux_WaitText.TabIndex = 0;
            // 
            // ux_Timer
            // 
            this.ux_Timer.Tick += new System.EventHandler(this.ux_Timer_Tick);
            // 
            // ux_ProgressBar
            // 
            this.ux_ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_ProgressBar.Location = new System.Drawing.Point(0, 32);
            this.ux_ProgressBar.Name = "ux_ProgressBar";
            this.ux_ProgressBar.Size = new System.Drawing.Size(384, 22);
            this.ux_ProgressBar.TabIndex = 1;
            // 
            // WaitNew
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(384, 54);
            this.ControlBox = false;
            this.Controls.Add(this.ux_ProgressBar);
            this.Controls.Add(this.ux_WaitText);
            this.Name = "WaitNew";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Working...";
            this.ResumeLayout(false);

        }

        #endregion

        private Label ux_WaitText;
        private ProgressBar ux_ProgressBar;
        private Timer ux_Timer;
    }
}