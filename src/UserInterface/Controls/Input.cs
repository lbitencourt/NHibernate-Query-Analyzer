using System.Windows.Forms;
using Ayende.NHibernateQueryAnalyzer.UserInterface.Interfaces;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface.Controls
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        public string Answer
        {
            get { return ux_Answer.Text; }
        }

        public string Ask(string message, string defaultAnswer, IView parent)
        {
            ux_Question.Text = message;
            ux_Answer.Text = defaultAnswer;
            ux_Answer.SelectAll();
            ux_Answer.Select();
            if (ShowDialog((IWin32Window)parent) == DialogResult.OK)
                return Answer;
            else
                return null;
        }
    }
}
