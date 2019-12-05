using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSimplified21Alex
{
    public partial class frmNewSimplified21 : Form
    {
        List<Image> ListCardImages = new List<Image>();
        List<int> ListCardValues = new List<int>();
        Random randNum = new Random();
        public frmNewSimplified21()
        {
            InitializeComponent();
        }

        private void frmNewSimplified21_Load(object sender, EventArgs e)
        {
            this.lblPlayers.Hide();
            this.lblPlayerTotal.Hide();
            this.lblDealers.Hide();
            this.lblDealerTotal.Hide();
            this.btnNewRound.Hide();
            this.btnHit.Hide();
            this.btnStay.Hide();
            CreateDeck();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this will close the program
            this.Close();

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //gives user all information they need to know to play the game
            MessageBox.Show("The rules of the game is simple. You need at least 6 cards to play the game," +
                " the goal of the game is to get as close to 21 or exactly 21. You would have to keep" +
                " hitting till you get to 17 then you can stay", "BlackJack!!!");

        }
        //procedure: CreateDeck
        //input: void
        //output: void
        //Description:  this procedure populates the deck of cards and the values
        private void CreateDeck()
        {
            //Add all cards to a list
            ListCardImages.Add(Properties.Resources.AC);
            ListCardImages.Add(Properties.Resources.AD);
            ListCardImages.Add(Properties.Resources.AH);
            ListCardImages.Add(Properties.Resources.AS);
            ListCardImages.Add(Properties.Resources._2C);
            ListCardImages.Add(Properties.Resources._2D);
            ListCardImages.Add(Properties.Resources._2H);
            ListCardImages.Add(Properties.Resources._2S);
            ListCardImages.Add(Properties.Resources._3C);
            ListCardImages.Add(Properties.Resources._3D);
            ListCardImages.Add(Properties.Resources._3H);
            ListCardImages.Add(Properties.Resources._3S);
            ListCardImages.Add(Properties.Resources._4C);
            ListCardImages.Add(Properties.Resources._4D);
            ListCardImages.Add(Properties.Resources._4H);
            ListCardImages.Add(Properties.Resources._4S);
            ListCardImages.Add(Properties.Resources._5C);
            ListCardImages.Add(Properties.Resources._5D);
            ListCardImages.Add(Properties.Resources._5H);
            ListCardImages.Add(Properties.Resources._5S);
            ListCardImages.Add(Properties.Resources._6C);
            ListCardImages.Add(Properties.Resources._6D);
            ListCardImages.Add(Properties.Resources._6H);
            ListCardImages.Add(Properties.Resources._6S);
            ListCardImages.Add(Properties.Resources._7C);
            ListCardImages.Add(Properties.Resources._7D);
            ListCardImages.Add(Properties.Resources._7H);
            ListCardImages.Add(Properties.Resources._7S);
            ListCardImages.Add(Properties.Resources._8C);
            ListCardImages.Add(Properties.Resources._8D);
            ListCardImages.Add(Properties.Resources._8H);
            ListCardImages.Add(Properties.Resources._8S);
            ListCardImages.Add(Properties.Resources._9C);
            ListCardImages.Add(Properties.Resources._9D);
            ListCardImages.Add(Properties.Resources._9H);
            ListCardImages.Add(Properties.Resources._9S);
            ListCardImages.Add(Properties.Resources.JC);
            ListCardImages.Add(Properties.Resources.JD);
            ListCardImages.Add(Properties.Resources.JS);
            ListCardImages.Add(Properties.Resources.JH);
            ListCardImages.Add(Properties.Resources.QC);
            ListCardImages.Add(Properties.Resources.QD);
            ListCardImages.Add(Properties.Resources.QH);
            ListCardImages.Add(Properties.Resources.QS);
            ListCardImages.Add(Properties.Resources.KC);
            ListCardImages.Add(Properties.Resources.KD);
            ListCardImages.Add(Properties.Resources.KH);
            ListCardImages.Add(Properties.Resources.KD);

            //Add the values of the cards respectively to the list of cards
            ListCardValues.Add(1);
            ListCardValues.Add(1);
            ListCardValues.Add(1);
            ListCardValues.Add(1);
            ListCardValues.Add(2);
            ListCardValues.Add(2);
            ListCardValues.Add(2);
            ListCardValues.Add(2);
            ListCardValues.Add(3);
            ListCardValues.Add(3);
            ListCardValues.Add(3);
            ListCardValues.Add(3);
            ListCardValues.Add(4);
            ListCardValues.Add(4);
            ListCardValues.Add(4);
            ListCardValues.Add(4);
            ListCardValues.Add(5);
            ListCardValues.Add(5);
            ListCardValues.Add(5);
            ListCardValues.Add(5);
            ListCardValues.Add(6);
            ListCardValues.Add(6);
            ListCardValues.Add(6);
            ListCardValues.Add(6);
            ListCardValues.Add(7);
            ListCardValues.Add(7);
            ListCardValues.Add(7);
            ListCardValues.Add(7);
            ListCardValues.Add(8);
            ListCardValues.Add(8);
            ListCardValues.Add(8);
            ListCardValues.Add(8);
            ListCardValues.Add(9);
            ListCardValues.Add(9);
            ListCardValues.Add(9);
            ListCardValues.Add(9);
            ListCardValues.Add(10);
            ListCardValues.Add(10);
            ListCardValues.Add(10);
            ListCardValues.Add(10);
            ListCardValues.Add(10);
            ListCardValues.Add(10);
            ListCardValues.Add(10);
            ListCardValues.Add(10);
            ListCardValues.Add(10);
            ListCardValues.Add(10);
            ListCardValues.Add(10);
            ListCardValues.Add(10);

        }
        //procedure: DealCard
        //input: ref picturebox aPictureBox, int randomIndex
        //output: int
        //Description:  this function deals the cards to each picture box
        private int DealCard(ref PictureBox aPictureBox, int randomIndex)
        {
            Image Card;
            int Value;

            //get the image from the random index
            Card = ListCardImages[randomIndex];

            //put the card image in the picturebox passed by reference
            aPictureBox.Image = Card;

            //remove the image from the list of cards
            ListCardImages.RemoveAt(randomIndex);

            //get the value of the card
            Value = ListCardValues[randomIndex];
            ListCardValues.RemoveAt(randomIndex);
            return Value;

        }

        private void picDealerCard3_Click(object sender, EventArgs e)
        {
            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
            }
            else
            {
                int random = randNum.Next(0, ListCardImages.Count() - 1);
                DealCard(ref this.picDealerCard3, random);
            }
        }

        private void picDealerCard2_Click(object sender, EventArgs e)
        {
            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
            }
            else
            {
                int random = randNum.Next(0, ListCardImages.Count() - 1);
                DealCard(ref this.picDealerCard2, random);
            }

        }

        private void picDealerCard1_Click(object sender, EventArgs e)
        {
            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
            }
            else
            {
                int random = randNum.Next(0, ListCardImages.Count() - 1);
                DealCard(ref this.picDealerCard1, random);
            }

        }

        private void picPlayerCard3_Click(object sender, EventArgs e)
        {
            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
            }
            else
            {
                int random = randNum.Next(0, ListCardImages.Count() - 1);
                DealCard(ref this.picPlayerCard3, random);
            }
        }

        private void picPlayerCard2_Click(object sender, EventArgs e)
        {
            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
            }
            else
            {
                int random = randNum.Next(0, ListCardImages.Count() - 1);
                DealCard(ref this.picPlayerCard2, random);
            }
        }

        private void picPlayerCard1_Click(object sender, EventArgs e)
        {
            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
            }
            else
            {
                int random = randNum.Next(0, ListCardImages.Count() - 1);
                DealCard(ref this.picPlayerCard1, random);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            CreateDeck();
            
        }
    }
}
