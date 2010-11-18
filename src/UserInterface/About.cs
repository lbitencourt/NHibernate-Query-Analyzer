using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void ux_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ux_NqaHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("http://www.assembla.com/wiki/show/NHibernateQueryAnalyzer");
            Process.Start(psi);
        }

        private void ux_NHibernateHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("http://www.nhibernate.org");
            Process.Start(psi);
        }

        private void ux_ReportBug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("mailto:NHibernateQueryAnalyzer@gmail.com");
            Process.Start(psi);
        }
    }
}
