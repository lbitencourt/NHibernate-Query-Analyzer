using System;
using System.Collections;
using System.Windows.Forms;
using Ayende.NHibernateQueryAnalyzer.Core.Model;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Interfaces;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    public partial class OpenProjectForm : Form
    {
        private readonly IMainPresenter presenter;
        private readonly IProjectsRepository repository;

        protected OpenProjectForm()
        {
            InitializeComponent();
        }

        public OpenProjectForm(IMainPresenter presenter)
		{
			this.presenter = presenter;
			repository = presenter.Repository;
			InitializeComponent();
			BindProjectList();
		}

        private void BindProjectList()
        {
            ux_ProjectList.Items.Clear();
            IList list = repository.GetAllProejcts();
            foreach (Project project in list)
            {
                ListViewItem lvi = new ListViewItem(project.Name);
                lvi.SubItems.Add(project.Id.ToString());
                lvi.Tag = project;
                ux_ProjectList.Items.Add(lvi);
            }
        }

        private void ux_ProjectList_ItemActivate(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ux_ProjectList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
                OpenProjectForm_KeyDown(sender, e);
        }

        private void OpenProjectForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else if (e.KeyCode == Keys.Delete && ux_ProjectList.SelectedItems.Count > 0)
            {
                DeleteSelectedProject();
            }
        }

        private void OpenProjectForm_Load(object sender, EventArgs e)
        {
            if (ux_ProjectList.Items.Count > 0)
                ux_ProjectList.Items[0].Selected = true;
        }

        private void ux_ContextMenu_Popup(object sender, EventArgs e)
        {
            ux_ContextMenu.MenuItems.Clear();
            if (ux_ProjectList.SelectedItems.Count > 0)
                ux_ContextMenu.MenuItems.Add(ux_ContextMenuDeleteProject);
        }

        private void ux_ContextMenuDeleteProject_Click(object sender, EventArgs e)
        {
            DeleteSelectedProject();
        }

        private void DeleteSelectedProject()
        {
            Project prj = (Project)ux_ProjectList.SelectedItems[0].Tag;
            if (presenter.DeleteProject(prj))
                BindProjectList();
        }

        public Project SelectedProject
        {
            get
            {
                if (ux_ProjectList.SelectedItems.Count == 0)
                    return null;
                return (Project)ux_ProjectList.SelectedItems[0].Tag;
            }
        }
    }
}
