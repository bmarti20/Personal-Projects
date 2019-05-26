using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void DrawCardButton_Click(object sender, EventArgs e)
        {
            DrawCard();
        }

        private void DrawCard()
        {
            if (!deck.Any())
                CreateDeck();

            Random rand = new Random();
            int draw = rand.Next(0, deck.Count());
            CardPictureBox.Image = deck[draw].card;
            DrawCardStatus.Text = deck[draw].name + "!";
            deck.RemoveAt(draw);
        }

        public static List<Card> deck = new List<Card>();

        private void CreateDeck()
        {
            deck.Clear();
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(0, 0, 73, 98)), "Ace of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(73, 0, 73, 98)), "2 of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(146, 0, 73, 98)), "3 of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(219, 0, 73, 98)), "4 of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(292, 0, 73, 98)), "5 of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(365, 0, 73, 98)), "6 of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(438, 0, 73, 98)), "7 of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(511, 0, 73, 98)), "8 of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(584, 0, 73, 98)), "9 of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(657, 0, 73, 98)), "10 of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(730, 0, 73, 98)), "Jack of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(803, 0, 73, 98)), "Queen of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(877, 0, 73, 98)), "King of Clubs"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(0, 98, 73, 98)), "Ace of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(73,98, 73, 98)), "2 of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(146, 98, 73, 98)), "3 of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(219, 98, 73, 98)), "4 of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(292, 98, 73, 98)), "5 of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(365, 98, 73, 98)), "6 of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(438, 98, 73, 98)), "7 of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(511, 98, 73, 98)), "8 of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(584, 98, 73, 98)), "9 of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(657, 98, 73, 98)), "10 of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(730, 98, 73, 98)), "Jack of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(803, 98, 73, 98)), "Queen of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(877, 98, 73, 98)), "King of Spades"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(0, 196, 73, 98)), "Ace of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(73, 196, 73, 98)), "2 of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(146, 196, 73, 98)), "3 of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(219, 196, 73, 98)), "4 of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(292, 196, 73, 98)), "5 of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(365, 196, 73, 98)), "6 of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(438, 196, 73, 98)), "7 of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(511, 196, 73, 98)), "8 of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(584, 196, 73, 98)), "9 of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(657, 196, 73, 98)), "10 of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(730, 196, 73, 98)), "Jack of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(803, 196, 73, 98)), "Queen of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(877, 196, 73, 98)), "King of Hearts"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(0, 294, 73, 98)), "Ace of Diamonds"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(73, 294, 73, 98)), "2 of Diamonds"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(146, 294, 73, 98)), "3 of Diamonds"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(219, 294, 73, 98)), "4 of Diamonds"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(292, 294, 73, 98)), "5 of Diamonds"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(365, 294, 73, 98)), "6 of Diamonds"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(438, 294, 73, 98)), "7 of Diamonds"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(511, 294, 73, 98)), "8 of Diamonds"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(584, 294, 73, 98)), "9 of Diamonds"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(657, 294, 73, 98)), "10 of Diamonds"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(730, 294, 73, 98)), "Jack of Diamonds"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(803, 294, 73, 98)), "Queen of Diamonds"));
            deck.Add(new Card(cropImage(Image.FromFile("cards.png"), new Rectangle(877, 294, 73, 98)), "King of Diamonds"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
