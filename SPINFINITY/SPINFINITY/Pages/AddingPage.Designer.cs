namespace SPINFINITY.Pages
{
    partial class AddingPage
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
            this.StringsTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // StringsTextBox
            // 
            this.StringsTextBox.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StringsTextBox.Location = new System.Drawing.Point(123, 74);
            this.StringsTextBox.Multiline = true;
            this.StringsTextBox.Name = "StringsTextBox";
            this.StringsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StringsTextBox.Size = new System.Drawing.Size(333, 407);
            this.StringsTextBox.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Location = new System.Drawing.Point(180, 600);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(227, 73);
            this.BackButton.TabIndex = 1;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPINFINITY.Properties.Resources.AddTextBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StringsTextBox);
            this.DoubleBuffered = true;
            this.Name = "AddingPage";
            this.Size = new System.Drawing.Size(581, 746);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StringsTextBox;
        private System.Windows.Forms.PictureBox BackButton;
    }
}
