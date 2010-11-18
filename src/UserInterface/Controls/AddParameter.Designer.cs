using System.Windows.Forms;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    partial class AddParameter
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
            this.ux_NameLabel = new System.Windows.Forms.Label();
            this.ux_Name = new System.Windows.Forms.TextBox();
            this.ux_TypeLabel = new System.Windows.Forms.Label();
            this.ux_TypeList = new System.Windows.Forms.ComboBox();
            this.ux_ValueLabel = new System.Windows.Forms.Label();
            this.ux_Value = new System.Windows.Forms.TextBox();
            this.ux_Ok = new System.Windows.Forms.Button();
            this.ux_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ux_NameLabel
            // 
            this.ux_NameLabel.Location = new System.Drawing.Point(8, 8);
            this.ux_NameLabel.Name = "ux_NameLabel";
            this.ux_NameLabel.Size = new System.Drawing.Size(56, 23);
            this.ux_NameLabel.TabIndex = 0;
            this.ux_NameLabel.Text = "Name:";
            // 
            // ux_Name
            // 
            this.ux_Name.Location = new System.Drawing.Point(72, 8);
            this.ux_Name.Name = "ux_Name";
            this.ux_Name.Size = new System.Drawing.Size(112, 20);
            this.ux_Name.TabIndex = 1;
            this.ux_Name.TextChanged += new System.EventHandler(this.ux_NameValue_TextChanged);
            // 
            // ux_TypeLabel
            // 
            this.ux_TypeLabel.Location = new System.Drawing.Point(200, 8);
            this.ux_TypeLabel.Name = "ux_TypeLabel";
            this.ux_TypeLabel.Size = new System.Drawing.Size(40, 23);
            this.ux_TypeLabel.TabIndex = 2;
            this.ux_TypeLabel.Text = "Type:";
            // 
            // ux_TypeList
            // 
            this.ux_TypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ux_TypeList.Location = new System.Drawing.Point(248, 8);
            this.ux_TypeList.Name = "ux_TypeList";
            this.ux_TypeList.Size = new System.Drawing.Size(121, 21);
            this.ux_TypeList.TabIndex = 3;
            // 
            // ux_ValueLabel
            // 
            this.ux_ValueLabel.Location = new System.Drawing.Point(384, 8);
            this.ux_ValueLabel.Name = "ux_ValueLabel";
            this.ux_ValueLabel.Size = new System.Drawing.Size(40, 23);
            this.ux_ValueLabel.TabIndex = 4;
            this.ux_ValueLabel.Text = "Value:";
            // 
            // ux_Value
            // 
            this.ux_Value.Location = new System.Drawing.Point(440, 8);
            this.ux_Value.Name = "ux_Value";
            this.ux_Value.Size = new System.Drawing.Size(104, 20);
            this.ux_Value.TabIndex = 5;
            this.ux_Value.TextChanged += new System.EventHandler(this.ux_NameValue_TextChanged);
            // 
            // ux_Ok
            // 
            this.ux_Ok.Enabled = false;
            this.ux_Ok.Location = new System.Drawing.Point(376, 40);
            this.ux_Ok.Name = "ux_Ok";
            this.ux_Ok.Size = new System.Drawing.Size(75, 23);
            this.ux_Ok.TabIndex = 6;
            this.ux_Ok.Text = "&OK";
            this.ux_Ok.Click += new System.EventHandler(this.ux_Ok_Click);
            // 
            // ux_Cancel
            // 
            this.ux_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ux_Cancel.Location = new System.Drawing.Point(472, 40);
            this.ux_Cancel.Name = "ux_Cancel";
            this.ux_Cancel.Size = new System.Drawing.Size(75, 23);
            this.ux_Cancel.TabIndex = 7;
            this.ux_Cancel.Text = "&Cancel";
            // 
            // AddParameterNew
            // 
            this.AcceptButton = this.ux_Ok;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.ux_Cancel;
            this.ClientSize = new System.Drawing.Size(560, 70);
            this.ControlBox = false;
            this.Controls.Add(this.ux_Cancel);
            this.Controls.Add(this.ux_Ok);
            this.Controls.Add(this.ux_Value);
            this.Controls.Add(this.ux_Name);
            this.Controls.Add(this.ux_ValueLabel);
            this.Controls.Add(this.ux_TypeList);
            this.Controls.Add(this.ux_TypeLabel);
            this.Controls.Add(this.ux_NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddParameterNew";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Parameter:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ux_NameLabel;
        private TextBox ux_Name;
        private Label ux_TypeLabel;
        private ComboBox ux_TypeList;
        private Label ux_ValueLabel;
        private TextBox ux_Value;
        private Button ux_Ok;
        private Button ux_Cancel;
    }
}