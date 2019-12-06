using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace ABetterSimplified21
{
    public partial class FrmABetter21 : Form
    {
        //global variables
        List<Image> ListCardImages = new List<Image>();
        List<int> ListCardValues = new List<int>();
        Random randnum = new Random();
        int playerTotal = 0;
        int dealerTotal = 0;
        int playerValue1 = 0;
        int playerValue2 = 0;
        int playerValue3 = 0;
        int playerValue4 = 0;
        int dealerValue1 = 0;
        int dealerValue2 = 0;
        int dealerValue3 = 0;
        int dealerValue4 = 0;
        int hitCount = 0;

        public FrmABetter21()
        {
            InitializeComponent();
        }

        private void FrmABetter21_Load(object sender, EventArgs e)
        {

            //Hide necessary labels in the form
            this.lblPlayers.Hide();
            this.lblDealers.Hide();
            this.lblPtotal.Hide();
            this.lblDtotal.Hide();
            this.btnHit.Hide();
            this.btnStay.Hide();
            this.picDealerCard1.Hide();
            this.picDealerCard2.Hide();
            this.picDealerCard3.Hide();
            this.picDealerCard4.Hide();
            this.picPlayerCard1.Hide();
            this.picPlayerCard2.Hide();
            this.picPlayerCard3.Hide();
            this.picPlayerCard4.Hide();
            this.btnNewRound.Hide();
            this.lblClick.Hide();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //this will close the program
            this.Close();

        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            //display how to play the game in a message box
            MessageBox.Show("The aim of the game is to get close to or exactly 21 without going over. At the and of the game the totals are display" +
                "and then if no play gets exactly 21, the Player who is closest to 21 wins", "Blackjack By Alex");
        }
        //procedure: CreateDeck
        //input: void
        //output: void
        //Description:  this procedure populates the deck of cards and the values
        private void CreateDeck()
        {
            ListCardImages.Clear();
            ListCardValues.Clear();
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

            ListCardImages.Add(Properties.Resources._10C);
            ListCardImages.Add(Properties.Resources._10D);
            ListCardImages.Add(Properties.Resources._10H);
            ListCardImages.Add(Properties.Resources._10S);

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
            Console.WriteLine("***List of card images count = " + ListCardImages.Count());

            //get the value of the card
            Value = ListCardValues[randomIndex];
            ListCardValues.RemoveAt(randomIndex);
            Console.WriteLine("***List of card values count = " + ListCardValues.Count());
            return Value;

        }

        private void PicPlayerCard1_Click(object sender, EventArgs e)
        {

            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
                Console.WriteLine("***Created new deck.");
            }
            else
            {
                int random = randnum.Next(0, ListCardImages.Count() - 1);
                playerValue1 = DealCard(ref this.picPlayerCard1, random);
                CalculateTotal();

            }
        }

        private void PicPlayerCard2_Click(object sender, EventArgs e)
        {
            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
            }
            else
            {
                int random = randnum.Next(0, ListCardImages.Count() - 1);
                playerValue2 = DealCard(ref this.picPlayerCard2, random);
                CalculateTotal();

            }
        }

        private void NewGame()
        {
            playerValue1 = 0;
            playerValue2 = 0;
            //call the reset function
            Reset();
            //Call the Create deck Procedure
            CreateDeck();



            int random = randnum.Next(0, ListCardImages.Count() - 1);
            dealerValue1 = DealCard(ref this.picDealerCard1, random);
            CalculateTotal();
            //display necessary cards
            this.picPlayerCard1.Show();
            this.picPlayerCard2.Show();
            this.picDealerCard1.Show();

            //display necessary labels and buttons
            this.btnHit.Show();
            this.lblPlayers.Show();
            this.lblPtotal.Show();
            this.lblDealers.Show();
            this.lblDtotal.Show();
            this.lblBlackjack.Hide();
            this.lblClick.Show();
            this.btnStay.Show();
        }
        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            //call the new game function
            NewGame();


            //display the newround button
            this.btnNewRound.Show();

        }

        //Function : CalculateTotal
        //input: void
        //Output: void
        //Description: This function Calculates the total of the Cards given to each player
        private void CalculateTotal()
        {

            playerTotal = playerValue1 + playerValue2 + playerValue3 + playerValue4;
            dealerTotal = dealerValue1 + dealerValue2 + dealerValue3 + dealerValue4;
            this.lblPtotal.Text = Convert.ToString(playerTotal);
            this.lblDtotal.Text = Convert.ToString(dealerTotal);
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            hitCount++;
            if (hitCount == 1)
            {
                this.btnStay.Enabled = false;
                if (ListCardImages.Count() == 0)
                {
                    MessageBox.Show("You are all out of cards! You will start a new game now", "Alex BlackJack Game");
                }

                else
                {
                    int random = randnum.Next(0, ListCardImages.Count() - 1);
                    playerValue3 = DealCard(ref this.picPlayerCard3, random);
                    CalculateTotal();
                    if (playerTotal == 21)
                    {
                        MessageBox.Show("BlackJack!! Player wins, You would now play another round", "Alex's BlackJack Game");
                        SoundPlayer ChaChing = new SoundPlayer(@"ChaChing.wav");
                        Reset();
                    }
                    else if (dealerTotal == 21)
                    {
                        MessageBox.Show("BlackJack!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                        SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                        Reset();
                    }
                    else if (playerTotal > 21)
                    {
                        MessageBox.Show("Bust!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                        SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                        Reset();
                    }
                    else if (dealerTotal > 21)
                    {
                        MessageBox.Show("Bust!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                        SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                        Reset();
                    }

                }

            }
            if (hitCount == 2)
            {
                this.btnStay.Enabled = false;
                if (ListCardImages.Count() == 0)
                {
                    MessageBox.Show("You are all out of cards! You will start a new game now", "Alex BlackJack Game");
                }
                else
                {
                    int random = randnum.Next(0, ListCardImages.Count() - 1);
                    playerValue4 = DealCard(ref this.picPlayerCard4, random);
                    CalculateTotal();

                    if (playerTotal == 21)
                    {
                        MessageBox.Show("BlackJack!! Player wins, You would now play another round", "Alex's BlackJack Game");
                        SoundPlayer ChaChing = new SoundPlayer(@"ChaChing.wav");
                        Reset();
                    }
                    else if (dealerTotal == 21)
                    {
                        MessageBox.Show("BlackJack!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                        SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                        Reset();

                    }
                    else if (playerTotal > 21)
                    {
                        MessageBox.Show("Bust!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                        SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                        Reset();
                    }
                    else if (dealerTotal > 21)
                    {
                        MessageBox.Show("Bust!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                        SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                        Reset();
                    }
                }


            }




        }
        private void DetermineWinner()
        {
            CalculateTotal();
            if (playerTotal == dealerTotal)
            {
                MessageBox.Show("Its A Tiee, You would now play another round", "Alex's BlackJack Game");
                Reset();
            }
            else if (playerTotal == 21)
            {
                MessageBox.Show("BlackJack!! Player wins, You would now play another round", "Alex's BlackJack Game");
                SoundPlayer ChaChing = new SoundPlayer(@"ChaChing.wav");
                Reset();
            }
            else if (dealerTotal == 21)
            {
                MessageBox.Show("BlackJack!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                Reset();
            }
            else if (playerTotal > 21)
            {
                MessageBox.Show("Bust!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                Reset();
            }
            else if (dealerTotal > 21)
            {
                MessageBox.Show("Bust!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                Reset();
            }
            else if (playerTotal < 21)
            {
                if (playerTotal > dealerTotal)
                {
                    MessageBox.Show(" Player wins, You would now play another round", "Alex's BlackJack Game");
                    SoundPlayer ChaChing = new SoundPlayer(@"ChaChing.wav");
                    Reset();
                }
                else if (dealerTotal > playerTotal)
                {
                    MessageBox.Show(" Dealer wins, You would now play another round", "Alex's BlackJack Game");
                    SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                    Reset();
                }
            }
        }
        private void Reset()
        {
            this.picPlayerCard1.Image = Properties.Resources.black_joker;
            this.picPlayerCard2.Image = Properties.Resources.black_joker;
            playerValue1 = 0;
            playerValue2 = 0;

        }

        private void btnNewRound_Click(object sender, EventArgs e)
        {
            //check if the amount of cards>= 6
            if (ListCardImages.Count() >= 6)
            {
                Reset();


            }
            //else call the new game function
            else
            {
                MessageBox.Show("You ran out of cards so you will start a new game now", "Alex's BlackJack Game");
                NewGame();
            }
            //the call the calculate total
            CalculateTotal();
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            this.btnHit.Enabled = false;
            this.btnStay.Enabled = false;
            if (ListCardImages.Count() == 0)
            {
                MessageBox.Show("You are all out of cards! You will start a new game now", "Alex BlackJack Game");
                NewGame();
            }

            else
            {
                int random = randnum.Next(0, ListCardImages.Count() - 1);
                dealerValue2 = DealCard(ref this.picDealerCard2, random);
                CalculateTotal();
                if (playerTotal == 21)
                {
                    MessageBox.Show("BlackJack!! Player wins, You would now play another round", "Alex's BlackJack Game");
                    SoundPlayer ChaChing = new SoundPlayer(@"ChaChing.wav");
                    Reset();
                }
                else if (dealerTotal == 21)
                {
                    MessageBox.Show("BlackJack!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                    SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                    Reset();
                }
                else if (playerTotal > 21)
                {
                    MessageBox.Show("Bust!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                    SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                    Reset();
                }
                else if (dealerTotal > 21)
                {
                    MessageBox.Show("Bust!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                    SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                    Reset();
                }
                if (dealerTotal > 17)
                {
                    DetermineWinner();
                }
                else
                {
                    this.btnStay.Enabled = false;
                    if (ListCardImages.Count() == 0)
                    {
                        MessageBox.Show("You are all out of cards! You will start a new game now", "Alex BlackJack Game");
                        NewGame();
                    }

                    else
                    {
                        int number = randnum.Next(0, ListCardImages.Count() - 1);
                        dealerValue3 = DealCard(ref this.picDealerCard3, number);
                        this.picDealerCard3.Show();
                        CalculateTotal();
                        if (playerTotal == 21)
                        {
                            MessageBox.Show("BlackJack!! Player wins, You would now play another round", "Alex's BlackJack Game");
                            SoundPlayer ChaChing = new SoundPlayer(@"ChaChing.wav");
                            Reset();
                        }
                        else if (dealerTotal == 21)
                        {
                            MessageBox.Show("BlackJack!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                            SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                            Reset();
                        }
                        else if (playerTotal > 21)
                        {
                            MessageBox.Show("Bust!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                            SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                            Reset();
                        }
                        else if (dealerTotal > 21)
                        {
                            MessageBox.Show("Bust!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                            SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                            Reset();
                        }
                        if (dealerTotal > 17)
                        {
                            DetermineWinner();
                        }
                        else
                        {
                            this.btnStay.Enabled = false;
                            if (ListCardImages.Count() == 0)
                            {
                                MessageBox.Show("You are all out of cards! You will start a new game now", "Alex BlackJack Game");
                                NewGame();
                            }

                            else
                            {
                                int value = randnum.Next(0, ListCardImages.Count() - 1);
                                dealerValue4 = DealCard(ref this.picDealerCard4, value);
                                this.picDealerCard4.Show();
                                CalculateTotal();
                                if (playerTotal == 21)
                                {
                                    MessageBox.Show("BlackJack!! Player wins, You would now play another round", "Alex's BlackJack Game");
                                    SoundPlayer ChaChing = new SoundPlayer(@"ChaChing.wav");
                                    Reset();
                                }
                                else if (dealerTotal == 21)
                                {
                                    MessageBox.Show("BlackJack!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                                    SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                                    Reset();
                                }
                                else if (playerTotal > 21)
                                {
                                    MessageBox.Show("Bust!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                                    SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                                    Reset();
                                }
                                else if (dealerTotal > 21)
                                {
                                    MessageBox.Show("Bust!! Dealer wins, You would now play another round", "Alex's BlackJack Game");
                                    SoundPlayer Sad = new SoundPlayer(@"Sad.wav");
                                    Reset();
                                }
                            }


                        }
                    }
                }
            }
        }

 
 }     }      