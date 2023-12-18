using SPINFINITY.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPINFINITY.Pages
{
    public partial class SpinPage : UserControl
    {
        private SoundPlayer ClickSound = new SoundPlayer(Resources.Click);
        private SoundPlayer InvalidNoice = new SoundPlayer(Resources.Invalid);
        private SoundPlayer Tock = new SoundPlayer(Resources.Tock);
        private SoundPlayer Congrats = new SoundPlayer(Resources.Congratulations_Sound_Effect);

        private float angle = 0;
        private System.Windows.Forms.Timer timer;
        public int Sec = 1;
        private int indextoberemove = 0000;
        string Won1, Won2, Won3, Won4, Won5, Won6, Won7, Won8, Won9, Won10;

        public SpinPage()
        {
            InitializeComponent();

            HistoryRefresh();
        }
  
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void YesToRemove1_Click(object sender, EventArgs e)
        {
            ClickSound.Play();
            names.RemoveAt(indextoberemove);
            WinnerPanel.Visible = false;
        }

        private void NoToRemove1_Click(object sender, EventArgs e)
        {
            ClickSound.Play();
            WinnerPanel.Visible = false;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            angle += Sec;
            if (angle >= 360)
                angle = 0;

            SpinWheel.Image = RotateAndStretchImage(Properties.Resources.Cyan_Wheel, angle);
        }

        private Image RotateAndStretchImage(Image img, float angle) {
            int stretchedWidth = (int)(img.Width * 1.5);
            int stretchedHeight = (int)(img.Height * 1.5);

            Bitmap rotatedStretchedImage = new Bitmap(stretchedWidth, stretchedHeight);
            using (Graphics g = Graphics.FromImage(rotatedStretchedImage))
            {
                g.TranslateTransform(stretchedWidth / 2, stretchedHeight / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-stretchedWidth / 2, -stretchedHeight / 2);
                g.DrawImage(img, new Rectangle(0, 0, stretchedWidth, stretchedHeight));
            }
            return rotatedStretchedImage;
        }

        private void BackMenuButton_Click(object sender, EventArgs e)  {
            ClickSound.Play();
            Pages.WelcomePage welcome = new Pages.WelcomePage();
            this.Controls.Clear();
            this.Controls.Add(welcome);
        }


        public void TextGiven(List<string> receivedNames) {
            names.AddRange(receivedNames);
            
        }
        private List<string> names = new List<string>();


        private async void SpinButton_Click(object sender, EventArgs e)
        {
            ClickSound.Play();
            if (names.Count == 0)
            {
                ResultTextBox.Text = "No List of Names";
                InvalidNoice.Play();
                return;
            }
            else
            {
                InitializeTimer();
                Sec = 7; ///Faster Spin of the Wheel
                SpinButton.Enabled = false;

                var totalSpinTimeMs = 3000;  // Total spin time in milliseconds
                var totalIterations = 20 * names.Count;  // Total iterations for the spin
                var delay = totalSpinTimeMs / totalIterations;
                Tock.PlayLooping();

                for (int i = 0; i < totalIterations; i++)
                {
                    var selectedName = names[i % names.Count]; // Cycle through the names
                    ResultTextBox.Text = selectedName;
                    await Task.Delay(delay);
                }
                Tock.Stop();
                var rnd = new Random();
                var winnerIndex = rnd.Next(names.Count);
                ResultTextBox.Text = $"{names[winnerIndex]}!";
                SpinButton.Enabled = true;

                Congrats.Play();

                Sec = 1; // Back to slow the Spin of the Wheel
                WonHistory(names[winnerIndex]);
                TheWInnerIs.Text = "The Winner is " + names[winnerIndex] +"!";
                WouldyouLike.Text = "Would you like to Remove '" + names[winnerIndex] + "' from the list?";
                indextoberemove = winnerIndex;
                WinnerPanel.Visible = true;
            }
        }

        private void GotoAdd_Click(object sender, EventArgs e)  {
            ClickSound.Play();
            Pages.AddingPage addArea = new Pages.AddingPage(names);
            this.Controls.Clear();
            this.Controls.Add(addArea);
        }


        private void WonHistory(string Winner) {
            string filepath = Path.Combine(Environment.CurrentDirectory, "HistoryStored.txt");
            if (!File.Exists(filepath))
            {
                File.WriteAllText(filepath, $"{Winner}");
            }
            else
            {
                File.AppendAllText(filepath, $",{Winner}");
            }

            HistoryRefresh();
        }
       
       
        public void HistoryRefresh() {
            string filepath = Path.Combine(Environment.CurrentDirectory, "HistoryStored.txt");
            if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath);

                foreach (string rows in lines)
                {
                    string[] columns = rows.Split(',');
                    int gg = columns.Length;
                    for (int i = gg-1; i >= 0; i--)  
                    {
                        if (i == gg - 1) Won1 = columns[i];
                        if (i == gg - 2) Won2 = columns[i];
                        if (i == gg - 3) Won3 = columns[i];
                        if (i == gg - 4) Won4 = columns[i];
                        if (i == gg - 5) Won5 = columns[i];
                        if (i == gg - 6) Won6 = columns[i];
                        if (i == gg - 7) Won7 = columns[i];
                        if (i == gg - 8) Won8 = columns[i];
                        if (i == gg - 9) Won9 = columns[i];
                        if (i == gg - 10) Won10 = columns[i];
                    }
                }
            }

            label1.Text = " " + Won1;
            label2.Text = " " + Won2;
            label3.Text = " " + Won3;
            label4.Text = " " + Won4;
            label5.Text = " " + Won5;
            label6.Text = " " + Won6;
            label7.Text = " " + Won7;
            label8.Text = " " + Won8;
            label9.Text = " " + Won9;
            label10.Text = " " + Won10;
        }

    }
}
