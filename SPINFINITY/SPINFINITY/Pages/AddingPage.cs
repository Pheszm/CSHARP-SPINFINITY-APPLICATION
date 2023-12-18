using SPINFINITY.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace SPINFINITY.Pages
{
    public partial class AddingPage : UserControl
    {
        private SoundPlayer ClickSound = new SoundPlayer(Resources.Click);
        public AddingPage(List<string> receivedNames)
        {
            InitializeComponent();  
            StringsTextBox.Lines = receivedNames.ToArray();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ClickSound.Play();
            Pages.SpinPage spinfinity = new Pages.SpinPage();
            spinfinity.TextGiven(StringsTextBox.Lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToList());
            this.Controls.Clear();
            this.Controls.Add(spinfinity);
        }
    }
}
    