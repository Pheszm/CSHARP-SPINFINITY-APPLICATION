using System.Windows.Forms;

namespace SPINFINITY
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WelcomePageArrive();
        }
        public void WelcomePageArrive()
        {
            Pages.WelcomePage welcome = new Pages.WelcomePage();
            MainPanel.Controls.Add(welcome);
        }
    }
}
