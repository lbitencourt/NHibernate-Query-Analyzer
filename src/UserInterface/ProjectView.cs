using System;
using System.IO;
using System.Windows.Forms;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Interfaces;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface
{
    public partial class ProjectView : NQADocument, IProjectView
    {
        private readonly IProjectPresenter presenter;
        public bool isEditable = true;

        protected ProjectView()
        {
            InitializeComponent();
        }

        public ProjectView(IProjectPresenter presenter, IMainView parentView)
            : base(parentView)
        {
            this.presenter = presenter;
            InitializeComponent();
            BindProject();
        }

        private void BindProject()
        {
            Title = presenter.Project.Name;
            BindProjectFileList();
        }

        private void BindProjectFileList()
        {
            ux_FileList.BeginUpdate();
            ux_FileList.Items.Clear();
            foreach (string fileName in presenter.Project.Files)
            {
                ListViewItem lvi = new ListViewItem(new[] { Path.GetFileName(fileName), fileName });
                ux_FileList.Items.Add(lvi);
            }
            ux_FileList.EndUpdate();
        }

        private void ux_FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ux_RemoveFile.Enabled = isEditable && ux_FileList.SelectedIndices.Count > 0;
        }

        private void ux_RemoveFile_Click(object sender, EventArgs e)
        {
            if (ux_FileList.SelectedItems.Count == 0)
                return;
            string fileName = ux_FileList.SelectedItems[0].SubItems[1].Text;
            presenter.Project.RemoveFile(fileName);
            HasChanges = true;
            ux_RemoveFile.Enabled = false;//disable the button as there is nothing now selected.
            BindProjectFileList();
        }

        private void ux_AddFile_Click(object sender, EventArgs e)
        {
            if (ux_AddFilesDialog.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string file in ux_AddFilesDialog.FileNames)
                {
                    presenter.Project.AddFile(file);
                }
                HasChanges = true;
                BindProjectFileList();
            }
        }

        private void ux_BuildProject_Click(object sender, EventArgs e)
        {
            presenter.BuildProject();
        }

        public void DisplayProjectState(bool isEditable, bool allowUserEdit)
        {
            this.isEditable = isEditable;
            ux_RemoveFile.Enabled = isEditable;
            ux_AddFile.Enabled = isEditable;
            ux_EditProject.Visible = allowUserEdit;
            ux_BuildProject.Enabled = isEditable;
        }

        public IProjectPresenter ProjectPresenter
        {
            get { return presenter; }
        }

        public override bool Save()
        {
            return presenter.SaveProject();
        }

        private void ux_EditProject_Click(object sender, EventArgs e)
        {
            presenter.EditProject();
        }

        public override bool SaveAs()
        {
            return presenter.SaveProjectAs();

        }
    }
}
