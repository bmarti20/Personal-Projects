using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomChanceSuite
{
    public partial class Yahtzee : Form
    {
        public Yahtzee()
        {
            InitializeComponent();
        }

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            List<Die> dice = new List<Die>();
            for (int i = 0; i < 5; i++)
                dice.Add(new Die(0, false));
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            RollButton.Text = "loaded";
        }


    }
}
