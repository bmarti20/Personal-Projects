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
            this.CoinPictureBox = new System.Windows.Forms.PictureBox();
            this.CoinFlipButton = new System.Windows.Forms.Button();
            this.HeadsOutcomesLabel = new System.Windows.Forms.Label();
            this.TailsOutcomesLabel = new System.Windows.Forms.Label();
            this.MultipleCoinFlipButton = new System.Windows.Forms.Button();
            this.FlipXTimesTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DiePictureBox = new System.Windows.Forms.PictureBox();
            this.RollDieButton = new System.Windows.Forms.Button();
            this.RollOutcomesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MultipleDieRollButton = new System.Windows.Forms.Button();
            this.RollXTimesTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CardPictureBox = new System.Windows.Forms.PictureBox();
            this.DrawCardButton = new System.Windows.Forms.Button();
            this.DrawCardStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coin Flip";
            // 
            // CoinPictureBox
            // 
            this.CoinPictureBox.Location = new System.Drawing.Point(17, 40);
            this.CoinPictureBox.Name = "CoinPictureBox";
            this.CoinPictureBox.Size = new System.Drawing.Size(128, 128);
            this.CoinPictureBox.TabIndex = 1;
            this.CoinPictureBox.TabStop = false;
            // 
            // CoinFlipButton
            // 
            this.CoinFlipButton.Location = new System.Drawing.Point(17, 172);
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
            this.HeadsOutcomesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadsOutcomesLabel.Location = new System.Drawing.Point(151, 69);
            this.HeadsOutcomesLabel.Name = "HeadsOutcomesLabel";
            this.HeadsOutcomesLabel.Size = new System.Drawing.Size(49, 15);
            this.HeadsOutcomesLabel.TabIndex = 4;
            this.HeadsOutcomesLabel.Text = "Heads: ";
            // 
            // TailsOutcomesLabel
            // 
            this.TailsOutcomesLabel.AutoSize = true;
            this.TailsOutcomesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TailsOutcomesLabel.Location = new System.Drawing.Point(151, 111);
            this.TailsOutcomesLabel.Name = "TailsOutcomesLabel";
            this.TailsOutcomesLabel.Size = new System.Drawing.Size(39, 15);
            this.TailsOutcomesLabel.TabIndex = 5;
            this.TailsOutcomesLabel.Text = "Tails: ";
            // 
            // MultipleCoinFlipButton
            // 
            this.MultipleCoinFlipButton.Location = new System.Drawing.Point(17, 197);
            this.MultipleCoinFlipButton.Name = "MultipleCoinFlipButton";
            this.MultipleCoinFlipButton.Size = new System.Drawing.Size(75, 23);
            this.MultipleCoinFlipButton.TabIndex = 6;
            this.MultipleCoinFlipButton.Text = "Flip X Times:";
            this.MultipleCoinFlipButton.UseVisualStyleBackColor = true;
            this.MultipleCoinFlipButton.Click += new System.EventHandler(this.MultipleCoinFlipButton_Click);
            // 
            // FlipXTimesTextbox
            // 
            this.FlipXTimesTextbox.Location = new System.Drawing.Point(98, 200);
            this.FlipXTimesTextbox.Name = "FlipXTimesTextbox";
            this.FlipXTimesTextbox.Size = new System.Drawing.Size(47, 20);
            this.FlipXTimesTextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Die Roll";
            // 
            // DiePictureBox
            // 
            this.DiePictureBox.Location = new System.Drawing.Point(236, 40);
            this.DiePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.DiePictureBox.Name = "DiePictureBox";
            this.DiePictureBox.Size = new System.Drawing.Size(128, 128);
            this.DiePictureBox.TabIndex = 9;
            this.DiePictureBox.TabStop = false;
            // 
            // RollDieButton
            // 
            this.RollDieButton.Location = new System.Drawing.Point(236, 172);
            this.RollDieButton.Margin = new System.Windows.Forms.Padding(2);
            this.RollDieButton.Name = "RollDieButton";
            this.RollDieButton.Size = new System.Drawing.Size(75, 21);
            this.RollDieButton.TabIndex = 10;
            this.RollDieButton.Text = "Roll";
            this.RollDieButton.UseVisualStyleBackColor = true;
            this.RollDieButton.Click += new System.EventHandler(this.RollDieButton_Click);
            // 
            // RollOutcomesLabel
            // 
            this.RollOutcomesLabel.AutoSize = true;
            this.RollOutcomesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollOutcomesLabel.Location = new System.Drawing.Point(369, 69);
            this.RollOutcomesLabel.Name = "RollOutcomesLabel";
            this.RollOutcomesLabel.Size = new System.Drawing.Size(20, 90);
            this.RollOutcomesLabel.TabIndex = 11;
            this.RollOutcomesLabel.Text = "1: \r\n2: \r\n3: \r\n4: \r\n5: \r\n6: \r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Outcomes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Outcomes:";
            // 
            // MultipleDieRollButton
            // 
            this.MultipleDieRollButton.Location = new System.Drawing.Point(236, 196);
            this.MultipleDieRollButton.Margin = new System.Windows.Forms.Padding(2);
            this.MultipleDieRollButton.Name = "MultipleDieRollButton";
            this.MultipleDieRollButton.Size = new System.Drawing.Size(75, 22);
            this.MultipleDieRollButton.TabIndex = 14;
            this.MultipleDieRollButton.Text = "Roll X Times";
            this.MultipleDieRollButton.UseVisualStyleBackColor = true;
            this.MultipleDieRollButton.Click += new System.EventHandler(this.MultipleDieRollButton_Click);
            // 
            // RollXTimesTextbox
            // 
            this.RollXTimesTextbox.Location = new System.Drawing.Point(316, 198);
            this.RollXTimesTextbox.Name = "RollXTimesTextbox";
            this.RollXTimesTextbox.Size = new System.Drawing.Size(47, 20);
            this.RollXTimesTextbox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Draw Card";
            // 
            // CardPictureBox
            // 
            this.CardPictureBox.Location = new System.Drawing.Point(479, 40);
            this.CardPictureBox.Name = "CardPictureBox";
            this.CardPictureBox.Size = new System.Drawing.Size(73, 98);
            this.CardPictureBox.TabIndex = 17;
            this.CardPictureBox.TabStop = false;
            // 
            // DrawCardButton
            // 
            this.DrawCardButton.Location = new System.Drawing.Point(477, 172);
            this.DrawCardButton.Name = "DrawCardButton";
            this.DrawCardButton.Size = new System.Drawing.Size(75, 23);
            this.DrawCardButton.TabIndex = 18;
            this.DrawCardButton.Text = "Draw";
            this.DrawCardButton.UseVisualStyleBackColor = true;
            this.DrawCardButton.Click += new System.EventHandler(this.DrawCardButton_Click);
            // 
            // DrawCardStatus
            // 
            this.DrawCardStatus.AutoSize = true;
            this.DrawCardStatus.Location = new System.Drawing.Point(479, 145);
            this.DrawCardStatus.Name = "DrawCardStatus";
            this.DrawCardStatus.Size = new System.Drawing.Size(0, 13);
            this.DrawCardStatus.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 234);
            this.Controls.Add(this.DrawCardStatus);
            this.Controls.Add(this.DrawCardButton);
            this.Controls.Add(this.CardPictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RollXTimesTextbox);
            this.Controls.Add(this.MultipleDieRollButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RollOutcomesLabel);
            this.Controls.Add(this.RollDieButton);
            this.Controls.Add(this.DiePictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FlipXTimesTextbox);
            this.Controls.Add(this.MultipleCoinFlipButton);
            this.Controls.Add(this.TailsOutcomesLabel);
            this.Controls.Add(this.HeadsOutcomesLabel);
            this.Controls.Add(this.CoinFlipButton);
            this.Controls.Add(this.CoinPictureBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Random Chance Suite";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CoinPictureBox;
        private System.Windows.Forms.Button CoinFlipButton;
        private System.Windows.Forms.Label HeadsOutcomesLabel;
        private System.Windows.Forms.Label TailsOutcomesLabel;
        private System.Windows.Forms.Button MultipleCoinFlipButton;
        private System.Windows.Forms.TextBox FlipXTimesTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox DiePictureBox;
        private System.Windows.Forms.Button RollDieButton;
        private System.Windows.Forms.Label RollOutcomesLabel;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MultipleDieRollButton;
        private System.Windows.Forms.TextBox RollXTimesTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox CardPictureBox;
        private System.Windows.Forms.Button DrawCardButton;
        private System.Windows.Forms.Label DrawCardStatus;
    }
}

