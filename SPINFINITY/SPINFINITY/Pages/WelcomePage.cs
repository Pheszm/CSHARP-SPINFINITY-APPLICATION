using SPINFINITY.Properties;
using System;
using System.Media;
using System.Windows.Forms;

namespace SPINFINITY.Pages
{
    public partial class WelcomePage : UserControl
    {
        public SoundPlayer ClickSound = new SoundPlayer(Resources.Click);

        public WelcomePage()
        {
            InitializeComponent();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            ClickSound.Play();
            Pages.AboutPage about = new Pages.AboutPage();
            this.Controls.Clear();
            this.Controls.Add(about);

        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            ClickSound.Play();
            Pages.SpinPage spin = new Pages.SpinPage();
            this.Controls.Clear();
            this.Controls.Add(spin);
        }
    }
}
