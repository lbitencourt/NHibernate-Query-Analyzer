using System;
using System.Windows.Forms;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    public partial class Wait : Form
    {
        protected Wait()
        {
            InitializeComponent();
        }

        public Wait(string message, int checkInterval, int shouldWaitFor)
		{
			InitializeComponent();
			
            ux_WaitText.Text = message;
			ux_ProgressBar.Maximum = shouldWaitFor;
			ux_ProgressBar.Step = checkInterval;
			ux_Timer.Interval = checkInterval;
			ux_Timer.Enabled = true;
		}

        private void ux_Timer_Tick(object sender, EventArgs e)
        {
            if (ux_ProgressBar.Value == ux_ProgressBar.Maximum)
                ux_ProgressBar.Value = ux_ProgressBar.Minimum;
            else
                ux_ProgressBar.PerformStep();

        }
    }
}
