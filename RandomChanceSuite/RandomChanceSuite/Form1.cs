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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Image coin;
        public static int numheads = 0;
        public static int numtails = 0;

        private void CoinFlipButton_Click(object sender, EventArgs e)
        {
            FlipCoin();
        }

        private void FlipCoin()
        {
            Random rand = new Random();
            switch (rand.Next(0, 2))
            {
                case 0:
                    coin = Image.FromFile("heads.jpg");
                    numheads++;
                    HeadsOutcomesLabel.Text = "Heads: " + numheads;
                    break;
                case 1:
                    coin = Image.FromFile("tails.jpg");
                    numtails++;
                    TailsOutcomesLabel.Text = "Tails: " + numtails;
                    break;
            }

            pictureBox1.Image = coin;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void MultipleCoinFlipButton_Click(object sender, EventArgs e)
        {
            int.TryParse(FlipXTimesTextbox.Text, out int numflips);

            for (int i = 0; i < numflips; i++)
                FlipCoin();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
