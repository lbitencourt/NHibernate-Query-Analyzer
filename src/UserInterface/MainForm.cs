using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Ayende.NHibernateQueryAnalyzer.Core.Model;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Controls;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Interfaces;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Presenters;
using log4net;
using WeifenLuo.WinFormsUI;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface
{
    public partial class MainForm : Form, IMainView
    {
        public const string DefaultNamePrefix = "New Project #";
        private readonly ILog logger = LogManager.GetLogger(typeof(MainForm));
        private readonly IMainPresenter presenter;

        private Wait wait;

        public IProjectView CurrentProjectView { get; set; }

        public MainForm(IProjectsRepository repository)
            : this()
        {
            presenter = new MainPresenter(this, repository);
        }

        private MainForm()
        {
            InitializeComponent();
            ux_DockingZone.DocumentStyle = DocumentStyles.DockingWindow;
        }

        public Project CurrentProject
        {
            get { return presenter.CurrentProject; }
            set
            {
                presenter.CurrentProject = value;
                UpdateProjectName();
            }
        }

        public void UpdateProjectName()
        {
            Text = presenter.CurrentProject != null
                ? presenter.CurrentProject.Name + " - NHibernate Query Analyzer"
                : "NHibernate Query Analyzer";
        }

        #region Event Handlers

        private void ux_MenuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ux_MenuFileNewProject_Click(object sender, EventArgs e)
        {
            presenter.DisplayNewProject();
        }


        private void ux_MenuFileOpenProject_Click(object sender, EventArgs e)
        {
            presenter.OpenProject();
        }

        private void ux_MenuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.SaveDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't save document because: " + ex.Message, "Document was not saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ux_MenuQuery_Popup(object sender, EventArgs e)
        {
            QueryForm qf = ux_DockingZone.ActiveDocument as QueryForm;
            bool queryWindowIsActive = (qf != null) && (qf.CanExecuteQuery);
            bool projectIsBuilt = ProjectIsBuilt();
            ux_MenuQueryExecute.Enabled = queryWindowIsActive;
            ux_MenuQueryOpen.Enabled = projectIsBuilt;
        }

        private bool ProjectIsBuilt()
        {
            foreach (DockContent content in ux_DockingZone.Documents)
            {
                if (content is IProjectView)
                {
                    return ((IProjectView)content).ProjectPresenter.Project.IsProjectBuilt;
                }
            }
            return false;
        }

        public IMainPresenter MainPresenter
        {
            get { return presenter; }
        }

        public Query SelectProjectQuery(Project prj)
        {
            using (OpenQueryForm oqf = new OpenQueryForm(prj))
            {
                if (oqf.ShowDialog(this) == DialogResult.OK) { return oqf.SelectedQuery; }
                return null;
            }
        }

        private void ux_MenuQueryExecute_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.ExecuteActiveQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't execute the currect query because: " + ex.Message, "Query error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ux_MenuFileNewQuery_Click(object sender, EventArgs e)
        {
            presenter.AddNewQuery();
        }

        private void ux_MenuQueryOpen_Click(object sender, EventArgs e)
        {
            presenter.OpenQuery();
        }

        private void ux_MenuWindowNext_Click(object sender, EventArgs e)
        {
            if (ux_DockingZone.Documents.Length <= 0) return;

            int index = Array.IndexOf(ux_DockingZone.Documents, ux_DockingZone.ActiveDocument);
            if (index + 1 < ux_DockingZone.Documents.Length)
            { ux_DockingZone.Documents[index + 1].DockHandler.Activate(); }
            else
            { ux_DockingZone.Documents[0].DockHandler.Activate(); }
        }

        private void ux_MenuWindowPrevious_Click(object sender, EventArgs e)
        {
            if (ux_DockingZone.Documents.Length <= 0) return;

            int index = Array.IndexOf(ux_DockingZone.Documents, ux_DockingZone.ActiveDocument);
            if (index - 1 >= 0)
            { ux_DockingZone.Documents[index - 1].DockHandler.Activate(); }
            else
            { ux_DockingZone.Documents[ux_DockingZone.Documents.Length - 1].DockHandler.Activate(); }
        }

        private void ux_MenuFileSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.SaveDocumentAs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't save document because: " + ex.Message, "Document was not saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ux_MenuFileNew_Popup(object sender, EventArgs e)
        {
            ux_MenuFileNewQuery.Enabled = (CurrentProject != null) && CurrentProject.IsProjectBuilt;
        }

        private void ux_MenuWindowClose_Click(object sender, EventArgs e)
        {
            presenter.CloseCurrentDocument();
        }

        private void ux_MenuFile_Popup(object sender, EventArgs e)
        {
            ux_MenuFileSaveAs.Enabled = ux_DockingZone.ActiveDocument != null;
            ux_MenuFileSave.Enabled = ux_DockingZone.ActiveDocument != null;
        }

        private void MainForm_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = !presenter.CloseProject();
        }

        private void ux_MenuFileNewMapping_Click(object sender, EventArgs e)
        {
            presenter.CreateNewHbmDocument();
        }

        private void ux_MenuFileNewConfiguration_Click(object sender, EventArgs e)
        {
            presenter.CreateNewCfgDocument();
        }

        private void ux_MenuFileOpenMapping_Click(object sender, EventArgs e)
        {
            try
            {
                if (ux_OpenMappingDialog.ShowDialog(this) != DialogResult.Cancel)
                {
                    presenter.OpenHbmDocument(ux_OpenMappingDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't open document because: " + ex.Message, "Problem openning document", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ux_MenuFileOpenConfiguration_Click(object sender, EventArgs e)
        {
            try
            {
                if (ux_OpenConfigDialog.ShowDialog(this) != DialogResult.Cancel)
                {
                    presenter.OpenCfgDocument(ux_OpenConfigDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't open document because: " + ex.Message, "Problem openning document", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ux_MenuHelpOnline_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("http://www.assembla.com/wiki/show/NHibernateQueryAnalyzer");
            Process.Start(psi);
        }

        private void ux_MenuHelpReportBug_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("mailto:NHibernateQueryAnalyzer@gmail.com");
            Process.Start(psi);
        }

        private void ux_MenuHelpAbout_Click(object sender, EventArgs e)
        {
            using (About about = new About())
            { about.ShowDialog(this); }
        }

        #endregion

        #region IMainView Implementation

        public event EventHandler TitleChanged;

        public void Display(IView view)
        {
            NQADocument d = view as NQADocument;
            if (d != null)
            { d.Show(ux_DockingZone); }
        }

        public SaveFileDialog SaveMappingDialog
        {
            get { return ux_SaveMappingDialog; }
        }

        public SaveFileDialog SaveConfigDialog
        {
            get { return ux_SaveConfigDialog; }
        }

        public IView ActiveDocument
        {
            get { return ux_DockingZone.ActiveDocument as IView; }
        }

        public IEnumerable Documents
        {
            get { return ux_DockingZone.Documents; }
        }

        public IView[] ShowUnsavedDialog(IView[] unsavedView)
        {
            using (UnsavedFilesForm uff = new UnsavedFilesForm())
            {
                uff.Views = unsavedView;
                if (uff.ShowDialog(this) == DialogResult.Cancel)
                {
                    return null;
                }
                return uff.SelectedView;
            }
        }

        /// <summary>
        /// Starts the wait message by the UI. The view needs to check every <c>checkInterval</c> 
        /// that the work was completed (using <c>HasFinishedWork()</c> method).
        /// The work should finish in shouldWaitFor, but there is no gurantee about it.
        /// <c>EndWait</c> is called to end the wait.
        /// </summary>
        /// <param name="waitMessage">The Wait message.</param>
        /// <param name="checkInterval">Check interval.</param>
        /// <param name="shouldWaitFor">Should wait for.</param>
        public void StartWait(string waitMessage, int checkInterval, int shouldWaitFor)
        {
            wait = new Wait(waitMessage, checkInterval, shouldWaitFor);
            wait.ShowDialog(this);
        }

        public void EndWait(string endMessage)
        {
            wait.Close();
            wait.Dispose();
            wait = null;
            ux_StatusBarMessages.Text = endMessage;
        }

        public void AddException(Exception ex)
        {
            ShowError(ex.ToString());
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ExecuteInUIThread(Delegate d, params object[] parameters)
        {
            if (logger.IsDebugEnabled)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Invoke Required: {0}, Executing method: {1} on {2}: ", InvokeRequired, d.Method.Name, d.Method.DeclaringType.FullName);
                foreach (object parameter in parameters)
                {
                    sb.Append(parameter != null ? parameter.ToString() : "null");
                    sb.Append(", ");
                }
                logger.Debug(sb.ToString());
            }
            if (InvokeRequired)
            {
                Invoke(d, parameters);
            }
            else
            {
                d.DynamicInvoke(parameters);
            }
        }

        public bool AskYesNo(string question, string title)
        {
            return MessageBox.Show(this, question, title, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public string Ask(string question, string answer)
        {
            using (Input input = new Input())
            {
                return input.Ask(question, answer, this);
            }
        }

        public bool HasChanges
        {
            get { return true; }
            set { }
        }

        public bool Save()
        {
            return false;
        }

        public string Title
        {
            get { return Text; }
            set
            {
                if (string.IsNullOrEmpty(value))
                { Text = "NHibernate Query Analyzer"; }
                else
                { Text = value + " - NHibernate Query Analyzer"; }

                if (TitleChanged != null) TitleChanged(this, EventArgs.Empty);
            }
        }

        public void Close(bool askToSave)
        {
            Close();
        }

        public bool SaveAs()
        {
            return true;
        }

        public Project SelectExistingProject()
        {
            using (OpenProjectForm opf = new OpenProjectForm(presenter))
            {
                if (opf.ShowDialog(this) == DialogResult.OK)
                {
                    return opf.SelectedProject;
                }
                return null;
            }
        }

        #endregion
    }
}
