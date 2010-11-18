using System.Windows.Forms;
using WeifenLuo.WinFormsUI;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ux_Menu = new System.Windows.Forms.MainMenu(this.components);
            this.ux_MenuFile = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileNew = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileNewProject = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileNewMapping = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileNewConfiguration = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileNewQuery = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileOpen = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileOpenProject = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileOpenMapping = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileOpenConfiguration = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileSave = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileSaveAs = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileSplitter = new System.Windows.Forms.MenuItem();
            this.ux_MenuFileExit = new System.Windows.Forms.MenuItem();
            this.ux_MenuQuery = new System.Windows.Forms.MenuItem();
            this.ux_MenuQueryExecute = new System.Windows.Forms.MenuItem();
            this.ux_MenuQuerySplitter = new System.Windows.Forms.MenuItem();
            this.ux_MenuQueryOpen = new System.Windows.Forms.MenuItem();
            this.ux_MenuWindow = new System.Windows.Forms.MenuItem();
            this.ux_MenuWindowNext = new System.Windows.Forms.MenuItem();
            this.ux_MenuWindowPrevious = new System.Windows.Forms.MenuItem();
            this.ux_MenuWindowSplitter = new System.Windows.Forms.MenuItem();
            this.ux_MenuWindowClose = new System.Windows.Forms.MenuItem();
            this.ux_MenuHelp = new System.Windows.Forms.MenuItem();
            this.ux_MenuHelpOnline = new System.Windows.Forms.MenuItem();
            this.ux_MenuHelpReportBug = new System.Windows.Forms.MenuItem();
            this.ux_MenuHelpAbout = new System.Windows.Forms.MenuItem();
            this.ux_DockingZone = new WeifenLuo.WinFormsUI.DockPanel();
            this.ux_StatusBar = new System.Windows.Forms.StatusBar();
            this.ux_StatusBarMessages = new System.Windows.Forms.StatusBarPanel();
            this.ux_StatusBarProgress = new System.Windows.Forms.StatusBarPanel();
            this.ux_SaveMappingDialog = new System.Windows.Forms.SaveFileDialog();
            this.ux_OpenMappingDialog = new System.Windows.Forms.OpenFileDialog();
            this.ux_SaveConfigDialog = new System.Windows.Forms.SaveFileDialog();
            this.ux_OpenConfigDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ux_StatusBarMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_StatusBarProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_Menu
            // 
            this.ux_Menu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ux_MenuFile,
            this.ux_MenuQuery,
            this.ux_MenuWindow,
            this.ux_MenuHelp});
            // 
            // ux_MenuFile
            // 
            this.ux_MenuFile.Index = 0;
            this.ux_MenuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ux_MenuFileNew,
            this.ux_MenuFileOpen,
            this.ux_MenuFileSave,
            this.ux_MenuFileSaveAs,
            this.ux_MenuFileSplitter,
            this.ux_MenuFileExit});
            this.ux_MenuFile.Text = "&File";
            this.ux_MenuFile.Popup += new System.EventHandler(this.ux_MenuFile_Popup);
            // 
            // ux_MenuFileNew
            // 
            this.ux_MenuFileNew.Index = 0;
            this.ux_MenuFileNew.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ux_MenuFileNewProject,
            this.ux_MenuFileNewMapping,
            this.ux_MenuFileNewConfiguration,
            this.ux_MenuFileNewQuery});
            this.ux_MenuFileNew.Text = "&New";
            this.ux_MenuFileNew.Popup += new System.EventHandler(this.ux_MenuFileNew_Popup);
            // 
            // ux_MenuFileNewProject
            // 
            this.ux_MenuFileNewProject.Index = 0;
            this.ux_MenuFileNewProject.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.ux_MenuFileNewProject.Text = "&Project";
            this.ux_MenuFileNewProject.Click += new System.EventHandler(this.ux_MenuFileNewProject_Click);
            // 
            // ux_MenuFileNewMapping
            // 
            this.ux_MenuFileNewMapping.Index = 1;
            this.ux_MenuFileNewMapping.Shortcut = System.Windows.Forms.Shortcut.CtrlM;
            this.ux_MenuFileNewMapping.Text = "&Mapping (hbm.xml)";
            this.ux_MenuFileNewMapping.Click += new System.EventHandler(this.ux_MenuFileNewMapping_Click);
            // 
            // ux_MenuFileNewConfiguration
            // 
            this.ux_MenuFileNewConfiguration.Index = 2;
            this.ux_MenuFileNewConfiguration.Text = "&Configuration (cfg.xml)";
            this.ux_MenuFileNewConfiguration.Click += new System.EventHandler(this.ux_MenuFileNewConfiguration_Click);
            // 
            // ux_MenuFileNewQuery
            // 
            this.ux_MenuFileNewQuery.Index = 3;
            this.ux_MenuFileNewQuery.Shortcut = System.Windows.Forms.Shortcut.CtrlQ;
            this.ux_MenuFileNewQuery.Text = "&Query";
            this.ux_MenuFileNewQuery.Click += new System.EventHandler(this.ux_MenuFileNewQuery_Click);
            // 
            // ux_MenuFileOpen
            // 
            this.ux_MenuFileOpen.Index = 1;
            this.ux_MenuFileOpen.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ux_MenuFileOpenProject,
            this.ux_MenuFileOpenMapping,
            this.ux_MenuFileOpenConfiguration});
            this.ux_MenuFileOpen.Text = "&Open";
            // 
            // ux_MenuFileOpenProject
            // 
            this.ux_MenuFileOpenProject.Index = 0;
            this.ux_MenuFileOpenProject.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.ux_MenuFileOpenProject.Text = "Open &Project...";
            this.ux_MenuFileOpenProject.Click += new System.EventHandler(this.ux_MenuFileOpenProject_Click);
            // 
            // ux_MenuFileOpenMapping
            // 
            this.ux_MenuFileOpenMapping.Index = 1;
            this.ux_MenuFileOpenMapping.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftO;
            this.ux_MenuFileOpenMapping.Text = "Open &Mapping...";
            this.ux_MenuFileOpenMapping.Click += new System.EventHandler(this.ux_MenuFileOpenMapping_Click);
            // 
            // ux_MenuFileOpenConfiguration
            // 
            this.ux_MenuFileOpenConfiguration.Index = 2;
            this.ux_MenuFileOpenConfiguration.Text = "Open &Configuration...";
            this.ux_MenuFileOpenConfiguration.Click += new System.EventHandler(this.ux_MenuFileOpenConfiguration_Click);
            // 
            // ux_MenuFileSave
            // 
            this.ux_MenuFileSave.Index = 2;
            this.ux_MenuFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.ux_MenuFileSave.Text = "&Save";
            this.ux_MenuFileSave.Click += new System.EventHandler(this.ux_MenuFileSave_Click);
            // 
            // ux_MenuFileSaveAs
            // 
            this.ux_MenuFileSaveAs.Index = 3;
            this.ux_MenuFileSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.ux_MenuFileSaveAs.Text = "Save &As";
            this.ux_MenuFileSaveAs.Click += new System.EventHandler(this.ux_MenuFileSaveAs_Click);
            // 
            // ux_MenuFileSplitter
            // 
            this.ux_MenuFileSplitter.Index = 4;
            this.ux_MenuFileSplitter.Text = "-";
            // 
            // ux_MenuFileExit
            // 
            this.ux_MenuFileExit.Index = 5;
            this.ux_MenuFileExit.Text = "E&xit";
            this.ux_MenuFileExit.Click += new System.EventHandler(this.ux_MenuFileExit_Click);
            // 
            // ux_MenuQuery
            // 
            this.ux_MenuQuery.Index = 1;
            this.ux_MenuQuery.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ux_MenuQueryExecute,
            this.ux_MenuQuerySplitter,
            this.ux_MenuQueryOpen});
            this.ux_MenuQuery.Text = "&Query";
            this.ux_MenuQuery.Popup += new System.EventHandler(this.ux_MenuQuery_Popup);
            // 
            // ux_MenuQueryExecute
            // 
            this.ux_MenuQueryExecute.Index = 0;
            this.ux_MenuQueryExecute.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.ux_MenuQueryExecute.Text = "&Execute Query";
            this.ux_MenuQueryExecute.Click += new System.EventHandler(this.ux_MenuQueryExecute_Click);
            // 
            // ux_MenuQuerySplitter
            // 
            this.ux_MenuQuerySplitter.Index = 1;
            this.ux_MenuQuerySplitter.Text = "-";
            // 
            // ux_MenuQueryOpen
            // 
            this.ux_MenuQueryOpen.Index = 2;
            this.ux_MenuQueryOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftQ;
            this.ux_MenuQueryOpen.Text = "&Open Query";
            this.ux_MenuQueryOpen.Click += new System.EventHandler(this.ux_MenuQueryOpen_Click);
            // 
            // ux_MenuWindow
            // 
            this.ux_MenuWindow.Index = 2;
            this.ux_MenuWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ux_MenuWindowNext,
            this.ux_MenuWindowPrevious,
            this.ux_MenuWindowSplitter,
            this.ux_MenuWindowClose});
            this.ux_MenuWindow.Text = "&Window";
            // 
            // ux_MenuWindowNext
            // 
            this.ux_MenuWindowNext.Index = 0;
            this.ux_MenuWindowNext.Shortcut = System.Windows.Forms.Shortcut.CtrlF6;
            this.ux_MenuWindowNext.Text = "&Next Window";
            this.ux_MenuWindowNext.Click += new System.EventHandler(this.ux_MenuWindowNext_Click);
            // 
            // ux_MenuWindowPrevious
            // 
            this.ux_MenuWindowPrevious.Index = 1;
            this.ux_MenuWindowPrevious.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftF6;
            this.ux_MenuWindowPrevious.Text = "&Previous Window";
            this.ux_MenuWindowPrevious.Click += new System.EventHandler(this.ux_MenuWindowPrevious_Click);
            // 
            // ux_MenuWindowSplitter
            // 
            this.ux_MenuWindowSplitter.Index = 2;
            this.ux_MenuWindowSplitter.Text = "-";
            // 
            // ux_MenuWindowClose
            // 
            this.ux_MenuWindowClose.Index = 3;
            this.ux_MenuWindowClose.Shortcut = System.Windows.Forms.Shortcut.CtrlF4;
            this.ux_MenuWindowClose.Text = "&Close Window";
            this.ux_MenuWindowClose.Click += new System.EventHandler(this.ux_MenuWindowClose_Click);
            // 
            // ux_MenuHelp
            // 
            this.ux_MenuHelp.Index = 3;
            this.ux_MenuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ux_MenuHelpOnline,
            this.ux_MenuHelpReportBug,
            this.ux_MenuHelpAbout});
            this.ux_MenuHelp.Text = "&Help";
            // 
            // ux_MenuHelpOnline
            // 
            this.ux_MenuHelpOnline.Index = 0;
            this.ux_MenuHelpOnline.Text = "&Online Help";
            this.ux_MenuHelpOnline.Click += new System.EventHandler(this.ux_MenuHelpOnline_Click);
            // 
            // ux_MenuHelpReportBug
            // 
            this.ux_MenuHelpReportBug.Index = 1;
            this.ux_MenuHelpReportBug.Text = "Report a &Bug";
            this.ux_MenuHelpReportBug.Click += new System.EventHandler(this.ux_MenuHelpReportBug_Click);
            // 
            // ux_MenuHelpAbout
            // 
            this.ux_MenuHelpAbout.Index = 2;
            this.ux_MenuHelpAbout.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.ux_MenuHelpAbout.Text = "&About";
            this.ux_MenuHelpAbout.Click += new System.EventHandler(this.ux_MenuHelpAbout_Click);
            // 
            // ux_DockingZone
            // 
            this.ux_DockingZone.ActiveAutoHideContent = null;
            this.ux_DockingZone.BackColor = System.Drawing.SystemColors.Control;
            this.ux_DockingZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ux_DockingZone.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.ux_DockingZone.Location = new System.Drawing.Point(0, 0);
            this.ux_DockingZone.Name = "ux_DockingZone";
            this.ux_DockingZone.Size = new System.Drawing.Size(792, 523);
            this.ux_DockingZone.TabIndex = 0;
            // 
            // ux_StatusBar
            // 
            this.ux_StatusBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ux_StatusBar.Location = new System.Drawing.Point(0, 523);
            this.ux_StatusBar.Name = "ux_StatusBar";
            this.ux_StatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.ux_StatusBarMessages,
            this.ux_StatusBarProgress});
            this.ux_StatusBar.ShowPanels = true;
            this.ux_StatusBar.Size = new System.Drawing.Size(792, 22);
            this.ux_StatusBar.TabIndex = 1;
            // 
            // ux_StatusBarMessages
            // 
            this.ux_StatusBarMessages.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.ux_StatusBarMessages.Name = "ux_StatusBarMessages";
            this.ux_StatusBarMessages.Text = "NHibernate Query Analyzer";
            this.ux_StatusBarMessages.Width = 153;
            // 
            // ux_StatusBarProgress
            // 
            this.ux_StatusBarProgress.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.ux_StatusBarProgress.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.ux_StatusBarProgress.MinWidth = 0;
            this.ux_StatusBarProgress.Name = "ux_StatusBarProgress";
            this.ux_StatusBarProgress.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw;
            this.ux_StatusBarProgress.Width = 622;
            // 
            // ux_SaveMappingDialog
            // 
            this.ux_SaveMappingDialog.AddExtension = false;
            this.ux_SaveMappingDialog.DefaultExt = "hbm.xml";
            this.ux_SaveMappingDialog.Filter = "NHibernate Mapping Files|*.hbm.xml";
            this.ux_SaveMappingDialog.Title = "Save the mapping file:";
            // 
            // ux_OpenMappingDialog
            // 
            this.ux_OpenMappingDialog.DefaultExt = "hbm.xml";
            this.ux_OpenMappingDialog.Filter = "NHibernate Mapping Files|*.hbm.xml";
            // 
            // ux_SaveConfigDialog
            // 
            this.ux_SaveConfigDialog.AddExtension = false;
            this.ux_SaveConfigDialog.DefaultExt = "cfg.xml";
            this.ux_SaveConfigDialog.Filter = "NHibernate Configuration|*.cfg.xml";
            // 
            // ux_OpenConfigDialog
            // 
            this.ux_OpenConfigDialog.DefaultExt = "cfg.xml";
            this.ux_OpenConfigDialog.Filter = "NHiberante Configuration|*.cfg.xml";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 545);
            this.Controls.Add(this.ux_DockingZone);
            this.Controls.Add(this.ux_StatusBar);
            this.Menu = this.ux_Menu;
            this.Name = "MainForm";
            this.Text = "NHibernate Query Analyzer";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.ux_StatusBarMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_StatusBarProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MainMenu ux_Menu;
        private MenuItem ux_MenuFile;
        private MenuItem ux_MenuFileNew;
        private MenuItem ux_MenuFileNewProject;
        private MenuItem ux_MenuFileNewQuery;
        private MenuItem ux_MenuFileNewMapping;
        private MenuItem ux_MenuFileNewConfiguration;
        private MenuItem ux_MenuFileOpen;
        private MenuItem ux_MenuFileOpenProject; 
        private MenuItem ux_MenuFileOpenMapping;
        private MenuItem ux_MenuFileOpenConfiguration;
        private MenuItem ux_MenuFileSave;
        private MenuItem ux_MenuFileSaveAs;
        private MenuItem ux_MenuFileSplitter;
        private MenuItem ux_MenuFileExit;
        private MenuItem ux_MenuQuery;
        private MenuItem ux_MenuQueryExecute;
        private MenuItem ux_MenuQueryOpen;
        private MenuItem ux_MenuQuerySplitter;
        private MenuItem ux_MenuWindow;
        private MenuItem ux_MenuWindowNext;
        private MenuItem ux_MenuWindowPrevious;
        private MenuItem ux_MenuWindowSplitter;
        private MenuItem ux_MenuWindowClose;
        private MenuItem ux_MenuHelp;
        private MenuItem ux_MenuHelpOnline;
        private MenuItem ux_MenuHelpReportBug;
        private MenuItem ux_MenuHelpAbout;

        private DockPanel ux_DockingZone;
        
        private StatusBar ux_StatusBar;
        private StatusBarPanel ux_StatusBarMessages;
        private StatusBarPanel ux_StatusBarProgress;

        private SaveFileDialog ux_SaveMappingDialog;
        private OpenFileDialog ux_OpenMappingDialog;
        private SaveFileDialog ux_SaveConfigDialog;
        private OpenFileDialog ux_OpenConfigDialog;
    }
}