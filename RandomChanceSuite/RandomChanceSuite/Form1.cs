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
        public Image die = Image.FromFile("die-faces.png");
        public static int numheads = 0;
        public static int numtails = 0;
        public static int[] dierolls = { 0, 0, 0, 0, 0, 0 };

        // Coin Flip Methods

        private void CoinFlipButton_Click(object sender, EventArgs e)
        {
            FlipCoin();
        }

        private void MultipleCoinFlipButton_Click(object sender, EventArgs e)
        {
            int.TryParse(FlipXTimesTextbox.Text, out int numflips);
            for (int i = 0; i < numflips; i++)
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

            CoinPictureBox.Image = coin;
            CoinPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Die Roll Methods

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

        private void RollDieButton_Click(object sender, EventArgs e)
        {
            RollDie();
        }

        private void MultipleDieRollButton_Click(object sender, EventArgs e)
        {
            int.TryParse(RollXTimesTextbox.Text, out int numrolls);
            for (int i = 0; i < numrolls; i++)
                RollDie();
        }

        private void RollDie()
        {
            Random rand = new Random();
            DiePictureBox.Image = Image.FromFile("die-faces.png");
            switch (rand.Next(0, 6))
            {
                case 0:
                    DiePictureBox.Image = cropImage(die, new Rectangle(0, 0, 128, 128));
                    dierolls[0]++;
                    break;
                case 1:
                    DiePictureBox.Image = cropImage(die, new Rectangle(128, 0, 128, 128));
                    dierolls[1]++;
                    break;
                case 2:
                    DiePictureBox.Image = cropImage(die, new Rectangle(256, 0, 128, 128));
                    dierolls[2]++;
                    break;
                case 3:
                    DiePictureBox.Image = cropImage(die, new Rectangle(384, 0, 128, 128));
                    dierolls[3]++;
                    break;
                case 4:
                    DiePictureBox.Image = cropImage(die, new Rectangle(512, 0, 128, 128));
                    dierolls[4]++;
                    break;
                case 5:
                    DiePictureBox.Image = cropImage(die, new Rectangle(640, 0, 128, 128));
                    dierolls[5]++;
                    break;
            }
            DiePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RollOutcomesLabel.Text = "1: " + dierolls[0] +
                "\n2: " + dierolls[1] +
                "\n3: " + dierolls[2] +
                "\n4: " + dierolls[3] +
                "\n5: " + dierolls[4] +
                "\n6: " + dierolls[5];
        }
    }
}
