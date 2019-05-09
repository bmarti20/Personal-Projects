using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWeaponEnchant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Weapon weapon;

        private void RollButton_Click(object sender, EventArgs e)
        {
            //Random rand = new Random();
            //switch (rand.Next(0, 3))
            //{
            //    case 0: weapon = new Dagger(); break;
            //    case 1: weapon = new Sword(); break;
            //    case 2: weapon = new Longsword(); break;
            //    default: break;
            //}
            switch (WeaponChoices.Text)
            {
                case "Dagger": weapon = new Dagger(); break;
                case "Sword": weapon = new Sword(); break;
                case "Longsword": weapon = new Longsword(); break;
                default: break;
            }

            NameTextbox.Text = weapon.name;
            DamageTextbox.Text = weapon.min + " - " + weapon.max;
            SpeedTextbox.Text = weapon.speed;
        }
    }
}
