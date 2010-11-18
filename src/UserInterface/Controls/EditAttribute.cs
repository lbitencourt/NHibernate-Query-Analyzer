using System;
using System.Collections;
using System.Collections.Specialized;
using System.Windows.Forms;
using Ayende.NHibernateQueryAnalyzer.SchemaEditing;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    public partial class EditAttribute : Form
    {
        private readonly AttributeFieldReference attribute;
        private StringDictionary fieldNames;
        private bool changesMade;

        protected EditAttribute()
        {
            InitializeComponent();
        }

        public EditAttribute(AttributeFieldReference attribute)
		{
			InitializeComponent();
			Text = "Edit Attribute: " + attribute.Name;
			this.attribute = attribute;
			DisplayValue();
			ux_DefaultValue.Enabled = attribute.HasValue;
		}

		private void DisplayValue()
		{
			if(attribute.Type.IsEnum)
			{
				ux_ValueText.Visible = false;
				ux_CheckBox.Visible = false;
				ux_List.Visible = true;
				foreach(string val in GetEnumXmlNames(attribute.Type))
				{
					ux_List.Items.Add(val);
				}
				ux_List.SelectedItem = fieldNames[attribute.Value.ToString()];
				ux_List.Select();
			}
			else if (attribute.Type == typeof(bool))
			{
				ux_ValueText.Visible = false;
				ux_List.Visible = false;
				ux_CheckBox.Visible = true;
				ux_CheckBox.Text = attribute.Name;
				ux_CheckBox.CheckState = ((bool)attribute.Value ) ? CheckState.Checked :  CheckState.Unchecked;				
				ux_CheckBox.Select();
			}
			else
			{
				ux_CheckBox.Visible = false;
				ux_List.Visible = false;
				ux_ValueText.Visible = true;
				ux_ValueText.Text = attribute.Value ==null ? "" : attribute.Value.ToString();
				ux_ValueText.Select();
			}
		}

		private ICollection GetEnumXmlNames(Type type)
		{
			fieldNames = SchemaEditor.GetEnumFieldsAndXMLNames(type);
			return fieldNames.Values;
		}

        private void ux_DefaultValue_Click(object sender, EventArgs e)
		{
			ux_ValueText.Text = "";
			Close();
		}

		private void ux_Ok_Click(object sender, EventArgs e)
		{
			DialogResult = changesMade ? DialogResult.OK : DialogResult.Cancel;
			Close();
		}

		private void ux_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ux_ValueText_TextChanged(object sender, EventArgs e)
		{
			changesMade = true;
		}

		private void ux_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ux_Ok.Enabled = true;
			changesMade = true;
		}

		private void ux_List_SelectedIndexChanged(object sender, EventArgs e)
		{
			changesMade = true;
			ux_Ok.Enabled = true;
		}

		public object AttributeValue
		{
			get
			{
				if(attribute.Type.IsEnum)
				{
					return GetEnumValue();
				}
			    if (attribute.Type == typeof(bool))
			    {
			        return ux_CheckBox.CheckState == CheckState.Checked;
			    }
			    return ux_ValueText.Text == "" ? null : ux_ValueText.Text;
			}
		}

		private object GetEnumValue()
		{
			string fieldName = null;
			foreach (DictionaryEntry entry in fieldNames)
			{
				if(entry.Value == ux_List.SelectedItem)
				{
					fieldName = (string)entry.Key;
					break;
				}
			}
			return Enum.Parse(attribute.Type, fieldName);
		}
    }
}
