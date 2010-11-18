using System.Windows.Forms;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    partial class EditAttribute
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
            this.ux_Cancel = new System.Windows.Forms.Button();
            this.ux_Ok = new System.Windows.Forms.Button();
            this.ux_ValueText = new System.Windows.Forms.TextBox();
            this.ux_ValueLabel = new System.Windows.Forms.Label();
            this.ux_DefaultValue = new System.Windows.Forms.Button();
            this.ux_List = new System.Windows.Forms.ComboBox();
            this.ux_CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ux_Cancel
            // 
            this.ux_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ux_Cancel.Location = new System.Drawing.Point(464, 48);
            this.ux_Cancel.Name = "ux_Cancel";
            this.ux_Cancel.Size = new System.Drawing.Size(75, 23);
            this.ux_Cancel.TabIndex = 15;
            this.ux_Cancel.Text = "&Cancel";
            this.ux_Cancel.Click += new System.EventHandler(this.ux_Cancel_Click);
            // 
            // ux_Ok
            // 
            this.ux_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ux_Ok.Location = new System.Drawing.Point(368, 48);
            this.ux_Ok.Name = "ux_Ok";
            this.ux_Ok.Size = new System.Drawing.Size(75, 23);
            this.ux_Ok.TabIndex = 14;
            this.ux_Ok.Text = "&OK";
            this.ux_Ok.Click += new System.EventHandler(this.ux_Ok_Click);
            // 
            // ux_ValueText
            // 
            this.ux_ValueText.Location = new System.Drawing.Point(72, 16);
            this.ux_ValueText.Name = "ux_ValueText";
            this.ux_ValueText.Size = new System.Drawing.Size(464, 20);
            this.ux_ValueText.TabIndex = 9;
            this.ux_ValueText.TextChanged += new System.EventHandler(this.ux_ValueText_TextChanged);
            // 
            // ux_ValueLabel
            // 
            this.ux_ValueLabel.Location = new System.Drawing.Point(16, 16);
            this.ux_ValueLabel.Name = "ux_ValueLabel";
            this.ux_ValueLabel.Size = new System.Drawing.Size(56, 23);
            this.ux_ValueLabel.TabIndex = 8;
            this.ux_ValueLabel.Text = "Value:";
            // 
            // ux_DefaultValue
            // 
            this.ux_DefaultValue.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.ux_DefaultValue.Location = new System.Drawing.Point(16, 48);
            this.ux_DefaultValue.Name = "ux_DefaultValue";
            this.ux_DefaultValue.Size = new System.Drawing.Size(120, 23);
            this.ux_DefaultValue.TabIndex = 16;
            this.ux_DefaultValue.Text = "&Default Value";
            this.ux_DefaultValue.Click += new System.EventHandler(this.ux_DefaultValue_Click);
            // 
            // ux_List
            // 
            this.ux_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ux_List.Location = new System.Drawing.Point(72, 16);
            this.ux_List.Name = "ux_List";
            this.ux_List.Size = new System.Drawing.Size(464, 21);
            this.ux_List.TabIndex = 17;
            this.ux_List.Visible = false;
            this.ux_List.SelectedIndexChanged += new System.EventHandler(this.ux_List_SelectedIndexChanged);
            // 
            // ux_CheckBox
            // 
            this.ux_CheckBox.Location = new System.Drawing.Point(16, 16);
            this.ux_CheckBox.Name = "ux_CheckBox";
            this.ux_CheckBox.Size = new System.Drawing.Size(520, 24);
            this.ux_CheckBox.TabIndex = 18;
            this.ux_CheckBox.Visible = false;
            this.ux_CheckBox.CheckedChanged += new System.EventHandler(this.ux_CheckBox_CheckedChanged);
            // 
            // EditAttributeNew
            // 
            this.AcceptButton = this.ux_Ok;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.ux_Cancel;
            this.ClientSize = new System.Drawing.Size(552, 78);
            this.ControlBox = false;
            this.Controls.Add(this.ux_CheckBox);
            this.Controls.Add(this.ux_List);
            this.Controls.Add(this.ux_DefaultValue);
            this.Controls.Add(this.ux_Cancel);
            this.Controls.Add(this.ux_Ok);
            this.Controls.Add(this.ux_ValueText);
            this.Controls.Add(this.ux_ValueLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditAttributeNew";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditAttribute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ux_Cancel;
        private Button ux_Ok;
        private TextBox ux_ValueText;
        private Button ux_DefaultValue;
        private Label ux_ValueLabel;
        private ComboBox ux_List;
        private CheckBox ux_CheckBox;
    }
}