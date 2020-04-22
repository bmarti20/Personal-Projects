using System;

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
            this.label6 = new System.Windows.Forms.Label();
            this.CalcTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MultButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
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
            this.CardPictureBox.Location = new System.Drawing.Point(471, 40);
            this.CardPictureBox.Name = "CardPictureBox";
            this.CardPictureBox.Size = new System.Drawing.Size(95, 128);
            this.CardPictureBox.TabIndex = 17;
            this.CardPictureBox.TabStop = false;
            // 
            // DrawCardButton
            // 
            this.DrawCardButton.Location = new System.Drawing.Point(471, 195);
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
            this.DrawCardStatus.Location = new System.Drawing.Point(470, 176);
            this.DrawCardStatus.Name = "DrawCardStatus";
            this.DrawCardStatus.Size = new System.Drawing.Size(0, 13);
            this.DrawCardStatus.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(615, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Calculator";
            // 
            // CalcTextbox
            // 
            this.CalcTextbox.Location = new System.Drawing.Point(611, 41);
            this.CalcTextbox.Name = "CalcTextbox";
            this.CalcTextbox.Size = new System.Drawing.Size(128, 20);
            this.CalcTextbox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 23;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(679, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(713, 67);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(28, 28);
            this.PlusButton.TabIndex = 25;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(713, 101);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(28, 28);
            this.MinusButton.TabIndex = 29;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(679, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 28);
            this.button6.TabIndex = 28;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(645, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 27;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(611, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 28);
            this.button4.TabIndex = 26;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MultButton
            // 
            this.MultButton.Location = new System.Drawing.Point(713, 135);
            this.MultButton.Name = "MultButton";
            this.MultButton.Size = new System.Drawing.Size(28, 28);
            this.MultButton.TabIndex = 33;
            this.MultButton.Text = "*";
            this.MultButton.UseVisualStyleBackColor = true;
            this.MultButton.Click += new System.EventHandler(this.MultButton_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(679, 135);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(28, 28);
            this.button9.TabIndex = 32;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(645, 135);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 28);
            this.button8.TabIndex = 31;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(611, 135);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 28);
            this.button7.TabIndex = 30;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // DivButton
            // 
            this.DivButton.Location = new System.Drawing.Point(713, 167);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(28, 28);
            this.DivButton.TabIndex = 37;
            this.DivButton.Text = "/";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Location = new System.Drawing.Point(679, 167);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(28, 28);
            this.EqualsButton.TabIndex = 36;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(645, 167);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(28, 28);
            this.button0.TabIndex = 35;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(611, 167);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(28, 28);
            this.DecimalButton.TabIndex = 34;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(611, 201);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(130, 23);
            this.ClearButton.TabIndex = 38;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(316, 236);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(137, 23);
            this.button10.TabIndex = 39;
            this.button10.Text = "Yahtzee!";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 271);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.MultButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalcTextbox);
            this.Controls.Add(this.label6);
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

        private void Form1_Load(object sender, EventArgs e)
        {

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CalcTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button MultButton;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button button10;
    }
}

