namespace SPINFINITY.Pages
{
    partial class WelcomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AboutButton = new System.Windows.Forms.PictureBox();
            this.ContinueButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AboutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContinueButton)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.Location = new System.Drawing.Point(181, 600);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(213, 56);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.TabStop = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.Color.Transparent;
            this.ContinueButton.Location = new System.Drawing.Point(128, 472);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(318, 91);
            this.ContinueButton.TabIndex = 2;
            this.ContinueButton.TabStop = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::SPINFINITY.Properties.Resources.WelcomeBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.ContinueButton);
            this.DoubleBuffered = true;
            this.Name = "WelcomePage";
            this.Size = new System.Drawing.Size(581, 746);
            ((System.ComponentModel.ISupportInitialize)(this.AboutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContinueButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ContinueButton;
        private System.Windows.Forms.PictureBox AboutButton;
    }
}
