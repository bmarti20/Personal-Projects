namespace RandomChanceSuite
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CoinFlipButton = new System.Windows.Forms.Button();
            this.HeadsOutcomesLabel = new System.Windows.Forms.Label();
            this.TailsOutcomesLabel = new System.Windows.Forms.Label();
            this.MultipleCoinFlipButton = new System.Windows.Forms.Button();
            this.FlipXTimesTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coin Flip";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CoinFlipButton
            // 
            this.CoinFlipButton.Location = new System.Drawing.Point(12, 110);
            this.CoinFlipButton.Name = "CoinFlipButton";
            this.CoinFlipButton.Size = new System.Drawing.Size(75, 23);
            this.CoinFlipButton.TabIndex = 2;
            this.CoinFlipButton.Text = "Flip Once";
            this.CoinFlipButton.UseVisualStyleBackColor = true;
            this.CoinFlipButton.Click += new System.EventHandler(this.CoinFlipButton_Click);
            // 
            // HeadsOutcomesLabel
            // 
            this.HeadsOutcomesLabel.AutoSize = true;
            this.HeadsOutcomesLabel.Location = new System.Drawing.Point(89, 49);
            this.HeadsOutcomesLabel.Name = "HeadsOutcomesLabel";
            this.HeadsOutcomesLabel.Size = new System.Drawing.Size(44, 13);
            this.HeadsOutcomesLabel.TabIndex = 4;
            this.HeadsOutcomesLabel.Text = "Heads: ";
            // 
            // TailsOutcomesLabel
            // 
            this.TailsOutcomesLabel.AutoSize = true;
            this.TailsOutcomesLabel.Location = new System.Drawing.Point(89, 79);
            this.TailsOutcomesLabel.Name = "TailsOutcomesLabel";
            this.TailsOutcomesLabel.Size = new System.Drawing.Size(35, 13);
            this.TailsOutcomesLabel.TabIndex = 5;
            this.TailsOutcomesLabel.Text = "Tails: ";
            // 
            // MultipleCoinFlipButton
            // 
            this.MultipleCoinFlipButton.Location = new System.Drawing.Point(12, 139);
            this.MultipleCoinFlipButton.Name = "MultipleCoinFlipButton";
            this.MultipleCoinFlipButton.Size = new System.Drawing.Size(75, 23);
            this.MultipleCoinFlipButton.TabIndex = 6;
            this.MultipleCoinFlipButton.Text = "Flip X Times:";
            this.MultipleCoinFlipButton.UseVisualStyleBackColor = true;
            this.MultipleCoinFlipButton.Click += new System.EventHandler(this.MultipleCoinFlipButton_Click);
            // 
            // FlipXTimesTextbox
            // 
            this.FlipXTimesTextbox.Location = new System.Drawing.Point(92, 141);
            this.FlipXTimesTextbox.Name = "FlipXTimesTextbox";
            this.FlipXTimesTextbox.Size = new System.Drawing.Size(39, 20);
            this.FlipXTimesTextbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 176);
            this.Controls.Add(this.FlipXTimesTextbox);
            this.Controls.Add(this.MultipleCoinFlipButton);
            this.Controls.Add(this.TailsOutcomesLabel);
            this.Controls.Add(this.HeadsOutcomesLabel);
            this.Controls.Add(this.CoinFlipButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Random Chance Suite";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CoinFlipButton;
        private System.Windows.Forms.Label HeadsOutcomesLabel;
        private System.Windows.Forms.Label TailsOutcomesLabel;
        private System.Windows.Forms.Button MultipleCoinFlipButton;
        private System.Windows.Forms.TextBox FlipXTimesTextbox;
    }
}

