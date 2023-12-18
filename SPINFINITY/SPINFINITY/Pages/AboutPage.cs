using SPINFINITY.Properties;
using System;
using System.Media;
using System.Windows.Forms;

namespace SPINFINITY.Pages
{
    public partial class AboutPage : UserControl
    {
        private SoundPlayer ClickSound = new SoundPlayer(Resources.Click);
        public AboutPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ClickSound.Play();
            this.Controls.Clear();
            Pages.WelcomePage welcome = new Pages.WelcomePage();
            this.Controls.Add(welcome);
        }
    }
}
