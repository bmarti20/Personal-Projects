namespace RandomWeaponEnchant
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
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.DamageTextbox = new System.Windows.Forms.TextBox();
            this.RollButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SpeedTextbox = new System.Windows.Forms.TextBox();
            this.WeaponChoices = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(12, 36);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(202, 22);
            this.NameTextbox.TabIndex = 0;
            // 
            // DamageTextbox
            // 
            this.DamageTextbox.Location = new System.Drawing.Point(12, 84);
            this.DamageTextbox.Name = "DamageTextbox";
            this.DamageTextbox.Size = new System.Drawing.Size(202, 22);
            this.DamageTextbox.TabIndex = 1;
            // 
            // RollButton
            // 
            this.RollButton.Location = new System.Drawing.Point(72, 172);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(75, 23);
            this.RollButton.TabIndex = 2;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Weapon Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Damage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Speed";
            // 
            // SpeedTextbox
            // 
            this.SpeedTextbox.Location = new System.Drawing.Point(12, 129);
            this.SpeedTextbox.Name = "SpeedTextbox";
            this.SpeedTextbox.Size = new System.Drawing.Size(202, 22);
            this.SpeedTextbox.TabIndex = 5;
            // 
            // WeaponChoices
            // 
            this.WeaponChoices.FormattingEnabled = true;
            this.WeaponChoices.Items.AddRange(new object[] {
            "Dagger",
            "Sword",
            "Longsword"});
            this.WeaponChoices.Location = new System.Drawing.Point(243, 84);
            this.WeaponChoices.Name = "WeaponChoices";
            this.WeaponChoices.Size = new System.Drawing.Size(144, 24);
            this.WeaponChoices.TabIndex = 7;
            this.WeaponChoices.Text = "Dagger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choose your weapon: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 207);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WeaponChoices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpeedTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.DamageTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Name = "Form1";
            this.Text = "Weapon Enchantment Randomizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox DamageTextbox;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SpeedTextbox;
        private System.Windows.Forms.ComboBox WeaponChoices;
        private System.Windows.Forms.Label label4;
    }
}

