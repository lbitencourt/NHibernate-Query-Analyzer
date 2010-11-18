using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Interfaces;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    public partial class UnsavedFilesForm : Form
    {
        private IView[] views;
        public IView[] Views
        {
            get { return views; }
            set { views = value; }
        }
        
        private IView[] selectedView = new IView[0];
        public IView[] SelectedView
        {
            get { return selectedView; }
            set { selectedView = value; }
        }

        private Label ux_Title;

        public UnsavedFilesForm()
        {
            InitializeComponent();
        }

        private void UnsavedFilesForm_Load(object sender, EventArgs e)
        {
            DocumentsToList();
        }

        private void DocumentsToList()
        {
            ux_FileList.BeginUpdate();
            ux_FileList.Items.Clear();
            ListViewItem lvi;
            foreach (IView doc in views)
            {
                lvi = new ListViewItem(doc.Title);
                lvi.Tag = doc;
                ux_FileList.Items.Add(lvi);
                lvi.Selected = true;
            }
            ux_FileList.EndUpdate();
        }

        private void UnsavedFilesForm_Closing(object sender, CancelEventArgs e)
        {
            if (DialogResult == DialogResult.Yes)
                SelectedItemsInListToSelectedDocuments();
        }

        private void SelectedItemsInListToSelectedDocuments()
        {
            ArrayList selected = new ArrayList();
            foreach (ListViewItem item in ux_FileList.SelectedItems)
            {
                selected.Add(item.Tag);
            }
            selectedView = (IView[])selected.ToArray(typeof(IView));
        }

        private void ux_YesNoCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ux_FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ux_Yes.Enabled = ux_FileList.SelectedItems.Count > 0;
        }
    }
}
