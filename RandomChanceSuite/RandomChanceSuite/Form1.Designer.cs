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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RollDieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coin Flip";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 79);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CoinFlipButton
            // 
            this.CoinFlipButton.Location = new System.Drawing.Point(16, 135);
            this.CoinFlipButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoinFlipButton.Name = "CoinFlipButton";
            this.CoinFlipButton.Size = new System.Drawing.Size(100, 28);
            this.CoinFlipButton.TabIndex = 2;
            this.CoinFlipButton.Text = "Flip Once";
            this.CoinFlipButton.UseVisualStyleBackColor = true;
            this.CoinFlipButton.Click += new System.EventHandler(this.CoinFlipButton_Click);
            // 
            // HeadsOutcomesLabel
            // 
            this.HeadsOutcomesLabel.AutoSize = true;
            this.HeadsOutcomesLabel.Location = new System.Drawing.Point(119, 60);
            this.HeadsOutcomesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeadsOutcomesLabel.Name = "HeadsOutcomesLabel";
            this.HeadsOutcomesLabel.Size = new System.Drawing.Size(57, 17);
            this.HeadsOutcomesLabel.TabIndex = 4;
            this.HeadsOutcomesLabel.Text = "Heads: ";
            // 
            // TailsOutcomesLabel
            // 
            this.TailsOutcomesLabel.AutoSize = true;
            this.TailsOutcomesLabel.Location = new System.Drawing.Point(119, 97);
            this.TailsOutcomesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TailsOutcomesLabel.Name = "TailsOutcomesLabel";
            this.TailsOutcomesLabel.Size = new System.Drawing.Size(46, 17);
            this.TailsOutcomesLabel.TabIndex = 5;
            this.TailsOutcomesLabel.Text = "Tails: ";
            // 
            // MultipleCoinFlipButton
            // 
            this.MultipleCoinFlipButton.Location = new System.Drawing.Point(16, 171);
            this.MultipleCoinFlipButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MultipleCoinFlipButton.Name = "MultipleCoinFlipButton";
            this.MultipleCoinFlipButton.Size = new System.Drawing.Size(100, 28);
            this.MultipleCoinFlipButton.TabIndex = 6;
            this.MultipleCoinFlipButton.Text = "Flip X Times:";
            this.MultipleCoinFlipButton.UseVisualStyleBackColor = true;
            this.MultipleCoinFlipButton.Click += new System.EventHandler(this.MultipleCoinFlipButton_Click);
            // 
            // FlipXTimesTextbox
            // 
            this.FlipXTimesTextbox.Location = new System.Drawing.Point(123, 174);
            this.FlipXTimesTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlipXTimesTextbox.Name = "FlipXTimesTextbox";
            this.FlipXTimesTextbox.Size = new System.Drawing.Size(51, 22);
            this.FlipXTimesTextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Die Roll";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(251, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 94);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // RollDieButton
            // 
            this.RollDieButton.Location = new System.Drawing.Point(262, 149);
            this.RollDieButton.Name = "RollDieButton";
            this.RollDieButton.Size = new System.Drawing.Size(75, 23);
            this.RollDieButton.TabIndex = 10;
            this.RollDieButton.Text = "Roll";
            this.RollDieButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 217);
            this.Controls.Add(this.RollDieButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FlipXTimesTextbox);
            this.Controls.Add(this.MultipleCoinFlipButton);
            this.Controls.Add(this.TailsOutcomesLabel);
            this.Controls.Add(this.HeadsOutcomesLabel);
            this.Controls.Add(this.CoinFlipButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Random Chance Suite";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button RollDieButton;
    }
}

