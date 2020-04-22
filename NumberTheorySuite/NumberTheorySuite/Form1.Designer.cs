namespace NumberTheorySuite
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
            this.PrimeTextbox = new System.Windows.Forms.TextBox();
            this.CheckPrimeButton = new System.Windows.Forms.Button();
            this.PrimeResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aTextbox = new System.Windows.Forms.TextBox();
            this.bTextbox = new System.Windows.Forms.TextBox();
            this.nTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.abmodnCalc = new System.Windows.Forms.Button();
            this.abmodnResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number to see if it\'s prime:";
            // 
            // PrimeTextbox
            // 
            this.PrimeTextbox.Location = new System.Drawing.Point(17, 36);
            this.PrimeTextbox.Name = "PrimeTextbox";
            this.PrimeTextbox.Size = new System.Drawing.Size(164, 20);
            this.PrimeTextbox.TabIndex = 1;
            // 
            // CheckPrimeButton
            // 
            this.CheckPrimeButton.Location = new System.Drawing.Point(187, 34);
            this.CheckPrimeButton.Name = "CheckPrimeButton";
            this.CheckPrimeButton.Size = new System.Drawing.Size(75, 23);
            this.CheckPrimeButton.TabIndex = 2;
            this.CheckPrimeButton.Text = "Check";
            this.CheckPrimeButton.UseVisualStyleBackColor = true;
            this.CheckPrimeButton.Click += new System.EventHandler(this.CheckPrimeButton_Click);
            // 
            // PrimeResult
            // 
            this.PrimeResult.AutoSize = true;
            this.PrimeResult.Location = new System.Drawing.Point(14, 59);
            this.PrimeResult.Name = "PrimeResult";
            this.PrimeResult.Size = new System.Drawing.Size(0, 13);
            this.PrimeResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "a^b modn";
            // 
            // aTextbox
            // 
            this.aTextbox.Location = new System.Drawing.Point(325, 49);
            this.aTextbox.Name = "aTextbox";
            this.aTextbox.Size = new System.Drawing.Size(59, 20);
            this.aTextbox.TabIndex = 5;
            // 
            // bTextbox
            // 
            this.bTextbox.Location = new System.Drawing.Point(325, 75);
            this.bTextbox.Name = "bTextbox";
            this.bTextbox.Size = new System.Drawing.Size(59, 20);
            this.bTextbox.TabIndex = 6;
            // 
            // nTextbox
            // 
            this.nTextbox.Location = new System.Drawing.Point(325, 101);
            this.nTextbox.Name = "nTextbox";
            this.nTextbox.Size = new System.Drawing.Size(59, 20);
            this.nTextbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "b:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "n";
            // 
            // abmodnCalc
            // 
            this.abmodnCalc.Location = new System.Drawing.Point(309, 127);
            this.abmodnCalc.Name = "abmodnCalc";
            this.abmodnCalc.Size = new System.Drawing.Size(75, 23);
            this.abmodnCalc.TabIndex = 11;
            this.abmodnCalc.Text = "Calculate";
            this.abmodnCalc.UseVisualStyleBackColor = true;
            this.abmodnCalc.Click += new System.EventHandler(this.abmodnCalc_Click);
            // 
            // abmodnResult
            // 
            this.abmodnResult.AutoSize = true;
            this.abmodnResult.Location = new System.Drawing.Point(307, 153);
            this.abmodnResult.Name = "abmodnResult";
            this.abmodnResult.Size = new System.Drawing.Size(0, 13);
            this.abmodnResult.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "(Limit for a^b is 2^1023)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 196);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.abmodnResult);
            this.Controls.Add(this.abmodnCalc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nTextbox);
            this.Controls.Add(this.bTextbox);
            this.Controls.Add(this.aTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrimeResult);
            this.Controls.Add(this.CheckPrimeButton);
            this.Controls.Add(this.PrimeTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Number Theory Suite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrimeTextbox;
        private System.Windows.Forms.Button CheckPrimeButton;
        private System.Windows.Forms.Label PrimeResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aTextbox;
        private System.Windows.Forms.TextBox bTextbox;
        private System.Windows.Forms.TextBox nTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button abmodnCalc;
        private System.Windows.Forms.Label abmodnResult;
        private System.Windows.Forms.Label label6;
    }
}

