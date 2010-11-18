using System;
using System.Windows.Forms;
using Ayende.NHibernateQueryAnalyzer.Core.Model;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    public partial class OpenQueryForm : Form
    {
        private readonly Project prj;

        protected OpenQueryForm()
        {
            InitializeComponent();
        }

        public OpenQueryForm(Project prj)
		{
			this.prj = prj;
			InitializeComponent();
			BindQueries();
		}

        private void BindQueries()
        {
            foreach (Query query in prj.Queries)
            {
                ux_QueryList.Items.Add(query.Name);
            }
        }

        private void queryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query q = prj.GetQueryWithName(ux_QueryList.SelectedItem.ToString());
            if (q != null)
                ux_QueryText.Text = q.Text;
        }

        private void ux_Ok_Click(object sender, EventArgs e)
        {
            if (ux_QueryList.SelectedItem == null)
            {
                DialogResult = DialogResult.None;
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ux_QueryList_DoubleClick(object sender, EventArgs e)
        {
            if (ux_QueryList.SelectedItem != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ux_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Query SelectedQuery
        {
            get { return prj.GetQueryWithName(ux_QueryList.SelectedItem.ToString()); }
        }
    }
}
