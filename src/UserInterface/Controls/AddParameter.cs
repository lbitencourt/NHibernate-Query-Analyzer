using System;
using System.Collections;
using System.Windows.Forms;
using Ayende.NHibernateQueryAnalyzer.Utilities;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    public partial class AddParameter : Form
    {
        private TypedParameter parameter;
        private Hashtable types;

       public AddParameter(string paramName)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			CreateTypesDictionary();
			ux_Name.Text = paramName;
		}

       public AddParameter(TypedParameter parameter)
           : this(parameter.Name)
		{
			ux_TypeList.SelectedText = parameter.Type.Name;
			ux_Value.Text = parameter.Value.ToString();
		}

		private void CreateTypesDictionary()
		{
			types = new Hashtable();
			types["DateTime"] = typeof(DateTime);
			types["boolean"] = typeof(bool);
			types["string"] = typeof(string);
			types["int"] = typeof(int);
			ux_TypeList.Items.AddRange(new[]{"int","string","boolean","DateTime"});
			ux_TypeList.SelectedItem = "int";
		}
        private void ux_NameValue_TextChanged(object sender, EventArgs e)
        {
            ux_Ok.Enabled = ux_Name.Text != "" &&
                ux_Value.Text != "";
        }

        private void ux_Ok_Click(object sender, EventArgs e)
        {
            object val;
            Type type = (Type)types[ux_TypeList.Text];
            try
            {
                val = Convert.ChangeType(ux_Value.Text, type);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't convert '" + ux_Value.Text + "' to " + ux_TypeList.Text);
                return;
            }
            parameter = new TypedParameter(ux_Name.Text,
                type, val);
            DialogResult = DialogResult.OK;
            Close();
        }

        public TypedParameter Parameter
        {
            get
            {
                return parameter;
            }
        }
    }
}
