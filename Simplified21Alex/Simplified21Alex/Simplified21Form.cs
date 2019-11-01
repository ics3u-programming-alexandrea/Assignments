/*
 * Created by: Alexandrea Udechukwu
 * Created on: 31-10-2019
 * Created for: ICS3U Programming
 * Assignment #5b - Simplified 21
 * This program is a simple game of blackjack with two players and a dealer
*/
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





namespace Simplified21Alex
{
    public partial class frmSimplified21 : Form

    {
       
       
        //declear global variables
        const int MAX_VALUE = 11;
        const int MIN_VALUE = 2;
        readonly Random numberGenerator = new Random();
        int hitCount2;
        int hitCount;
        int stays2;
        int cardp1;
        int cardp2;
        int cardp3;
        int cardp4;
        int cardpp1;
        int cardpp2;
        int cardpp3;
        int cardpp4;
        int cardd1;
        int cardd2;
        int cardd3;
        int cardd4;
        int player1total;
        int player2total;
        int dealerstotal;

        public frmSimplified21()
        {
            InitializeComponent();
            //Hide necessary labels in the form
           this.lblPlayers.Hide();
           this.lblPlayer2.Hide();
           this.lblP2total.Hide();
           this.lblDealers.Hide();
           this.lblPtotal.Hide();
           this.lblDtotal.Hide();
            this.lblCardd1.Hide();
            this.lblCardd2.Hide();
            this.lblCardd3.Hide();
            this.lblCardp1.Hide();
            this.lblCardp2.Hide();
            this.lblCardp3.Hide();
            this.lblCardp4.Hide();
            this.lblCardpp1.Hide();
            this.lblCardpp2.Hide();
            this.lblCardpp3.Hide();
            this.lblCardpp4.Hide();
            this.lblCardd4.Hide();
            this.btnHit.Hide();
            this.btnStay.Hide();
            this.lblComment.Hide();
            this.btnStay2.Hide();
            this.btnHit2.Hide();
          
        }
        

        private void BtnStart_Click_1(object sender, EventArgs e)
        {
            //enable buttons for the first Player and disable buttons for the second Player
            this.btnHit2.Enabled = false;
            this.btnStay2.Enabled = false;
            this.btnHit.Enabled = true;
            this.btnStay.Enabled = true;
            //Show and hide necessary labels
            this.lblPtotal.Show();
            this.lblP2total.Show();
            this.lblBlackjack.Hide();
            this.lblPlayers.Show();
            this.btnHit.Show();
            this.btnStay.Show();
            this.lblCardd1.Show();
            this.lblPlayer2.Show();
            this.btnHit2.Show();
            this.btnStay2.Show();
            this.lblDealers.Show();
            this.lblCardp1.Show();
            this.lblCardp2.Show();
            this.lblCardpp1.Show();
            this.lblCardpp2.Show();
            
            //assign the variables to a label and conver to string
            cardp1 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardp1.Text = Convert.ToString(cardp1);
            cardp2 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardp2.Text = Convert.ToString(cardp2);
            cardp3 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardp3.Text = Convert.ToString(cardp3);
            cardp4 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardp4.Text = Convert.ToString(cardp4);

            cardpp1 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardpp1.Text = Convert.ToString(cardpp1);
            cardpp2 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardpp2.Text = Convert.ToString(cardpp2);
            cardpp3 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardpp3.Text = Convert.ToString(cardpp3);
            cardpp4 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardpp4.Text = Convert.ToString(cardpp4);


            cardd1 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardd1.Text = Convert.ToString(cardd1);
            cardd2 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardd2.Text = Convert.ToString(cardd2);
            cardd3 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardd3.Text = Convert.ToString(cardd3);
            cardd4 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardd4.Text=Convert.ToString(cardd4);
            
            //Calculate the total of the two users and the dealer
            player1total = cardp1 + cardp2 ;
            lblPtotal.Text = Convert.ToString(player1total);
            player2total = cardpp1 + cardpp2 ;
            lblP2total.Text = Convert.ToString(player2total);
            dealerstotal = cardd1 + cardd2;
            lblDtotal.Text = Convert.ToString(dealerstotal);

            //check the total of the users and compare them to see if anyone wins or loses yet and then show and hide necessary labels
            if(player1total>21)
            {
                this.lblComment.Text = Convert.ToString("Bust!! Player1 loses");
                
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            else if(player2total > 21)
            {
                this.lblComment.Text = Convert.ToString("Bust!! Player2 loses");
               
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            else if(dealerstotal>21)
            {
                this.lblComment.Text = Convert.ToString("Bust!! Dealer wins");
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            if (player1total == 21)
            {
                this.lblComment.Text = Convert.ToString("BlackJack!! Player1 wins");
                this.lblComment.Show();
                this.lblPtotal.Show();
                this.lblP2total.Show();
            }
            else if (player2total == 21)
            {
                this.lblComment.Text = Convert.ToString("BlackJack!! Player2 wins");
                this.lblComment.Show();
            }
            else
            {
                this.lblComment.Hide();
            }

            this.Refresh();
            if (player2total > 21)
            {
                this.lblComment.Text = Convert.ToString("Bust!! Player2 loses");
                this.btnHit2.Enabled = false;
                this.btnStay2.Enabled = false;
            }
            else if (player2total > 21)
            {
                this.lblComment.Text = Convert.ToString("Bust!! Player2 loses");
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            else if (dealerstotal > 21)
            {
                this.lblComment.Text = Convert.ToString("Bust!! Dealer wins");
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            if (player1total == 21)
            {
                this.lblComment.Text = Convert.ToString("BlackJack!! Player1 wins");
                this.lblComment.Show();
                lblPtotal.Show();

                lblP2total.Show();
            }
            else if (player2total == 21)
            {
                this.lblComment.Text = Convert.ToString("BlackJack!! Player2 wins");
                this.lblComment.Show();
            }
            else
            {
                this.lblComment.Hide();
            }

            

        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            //this will exit the form
            this.Close();
        }

       
        private void BtnHit_Click_1(object sender, EventArgs e)
        {
            //make an increament for the amount of times the button is hit
            hitCount++;
            //disable and enable necessary buttons
            this.btnHit.Enabled = false;
            this.btnStay.Enabled = false;
            this.btnHit2.Enabled = true;
            this.btnStay2.Enabled = true;


            //using the amount of times the button is clicked, Show various card and display total
            if (hitCount == 1)
            {
                this.lblCardp3.Show();
                lblPtotal.Show();

                lblP2total.Show();
                player1total = cardp1 + cardp2 + cardp3;
                lblPtotal.Text = Convert.ToString(player1total);
                //check to see if the player1 went over 21 and display necessary buttons
                if (player1total > 21)
                {
                    this.lblComment.Show();
                    lblPtotal.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Player1 loses");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    lblCardd2.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;



                }
                //check to see if the player2 went over 21 and display necessary buttons
                else if (player2total > 21)
                {
                    this.lblComment.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Player2 loses");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                }
                //check to see if the dealer went over 21 and display necessary buttons
                else if (dealerstotal > 21)
                {
                    this.lblComment.Show();
                    lblCardd2.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Dealer wins");
                     SoundPlayer CorrectNoise = new SoundPlayer(@"CorrectAnswer.wav");
                CorrectNoise.Play();
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                }
                //check to see if the player1total equals 21 and display necessary buttons
                if (player1total == 21)
                {
                    this.lblComment.Text = Convert.ToString("BlackJack!! Player1 wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                    
                }
                //check to see if the player2total equals 21 and display necessary buttons
                else if (player2total == 21)
                {
                    this.lblComment.Text = Convert.ToString("BlackJack!! Player2 wins");
                    this.lblComment.Show();
                    this.btnHit2.Enabled = false;
                    this.btnStay2.Enabled = false;
                }
                //check to see if the dealerstotal equals 21 and display necessary buttons
                else if (dealerstotal == 21)
                {
                    lblCardd2.Show();
                    this.lblComment.Text = Convert.ToString("BlackJack!! Dealer wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                }
            }
            //using the amount of times a button is clicked, display additional card and calculate
            else if (hitCount == 2)
            {
                player1total = cardp1 + cardp2 + cardp3 + cardp4;
                this.lblCardp4.Show();
                lblPtotal.Text = Convert.ToString(player1total);
                if (player1total > 21)
                {
                    this.lblComment.Show();
                    lblPtotal.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Player1 loses");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    lblCardd2.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;



                }
                //check to see if the player2 went over 21 and display necessary buttons
                else if (player2total > 21)
                {
                    this.lblComment.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Player2 loses");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                }
                //check to see if the dealer went over 21 and display necessary comments
                else if (dealerstotal > 21)
                {
                    this.lblComment.Show();
                    lblCardd2.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Dealer wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                   
                }
                //check to see if player1 total is 21
                if (player1total == 21)
                {
                    this.lblComment.Text = Convert.ToString("BlackJack!! Player1 wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                }
                //check to see if player2 total is 21
                else if (player2total == 21)
                {
                    this.lblComment.Text = Convert.ToString("BlackJack!! Player2 wins");
                    this.lblComment.Show();
                    this.btnHit2.Enabled = false;
                    this.btnStay2.Enabled = false;
                }
                //check to see if dealers total is 21
                else if (dealerstotal == 21)
                {
                    lblCardd2.Show();
                    this.lblComment.Text = Convert.ToString("BlackJack!! Dealer wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    
                }
            }
            //show and hide necessary labels and buttons
            this.lblCardp3.Show();
            this.lblComment.Hide();
            lblDtotal.Hide();
            lblPtotal.Show();
            lblPtotal.Text = Convert.ToString(player1total);
            lblP2total.Show();
            //check to see if player1 went over 21 and display necessary labels
            if (player1total > 21)
                {
                    this.lblComment.Show();
                    lblPtotal.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Player1 loses");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    lblCardd2.Show();
                     this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;



                }
            //check to see if player2 went over 21 and display necessary labels
            else if (player2total > 21)
                {
                    this.lblComment.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Player2 loses");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                }
            //check to see if dealer went over 21 and display necessary labels
            else if (dealerstotal > 21)
                {
                    this.lblComment.Show();
                    lblCardd2.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Dealer wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                }
            //check to see if player1total equals 21 and display necessary labels
            if (player1total == 21)
                {
                    this.lblComment.Text = Convert.ToString("BlackJack!! Player1 wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
                }
            //check to see if player2total equals 21 and display necessary labels
            else if (player2total == 21)
                {
                    this.lblComment.Text = Convert.ToString("BlackJack!! Player2 wins");
                    this.lblComment.Show();
                }
            //check to see if dealer total equals 21 and display necessary labels
            else if (dealerstotal == 21)
                {
                    lblCardd2.Show();
                    this.lblComment.Text = Convert.ToString("BlackJack!! Dealer wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                }

          



        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            //display how to play the game in a message box
            MessageBox.Show("The aim of the game is to get close to or exactly 21 without going over. At the and of the game the totals are display" +
                "and then if no play gets exactly 21, the Player who is closest to 21 wins", "Blackjack By Alex");
        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
            //enable and disable necessary buttons
            this.btnHit2.Enabled = true;
            this.btnStay2.Enabled = true;
            this.btnHit.Enabled = false;
            this.btnStay.Enabled = false;
            
        }
           


        private void BtnHit2_Click(object sender, EventArgs e)
        {
            //make an increament for each time the button is clicked
            hitCount2++;
           
            //using the amount of times the button is hit display the right amount of cards and totals
            if (hitCount2 == 1)
            {
                
                this.lblCardpp3.Show();
                lblPtotal.Show();
                lblP2total.Show();
                player2total = cardpp1 + cardpp2 + cardpp3;
                lblP2total.Text = Convert.ToString(player2total);
                //check to see if player1 goes over 21 and display comments
                if (player2total > 21)
                {
                    this.lblComment.Show();
                    lblP2total.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Player2 loses");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    lblCardd2.Show();
                    this.btnHit2.Enabled = false;
                    this.btnStay2.Enabled = false;



                }
                //check to see if player2 goes over 21 and display comments
                else if (player2total > 21)
                {
                    this.lblComment.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Player2 loses");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit2.Enabled = false;
                    this.btnStay2.Enabled = false;
                }
                //check to see if dealer goes over 21 and display comments
                else if (dealerstotal > 21)
                {
                    this.lblComment.Show();
                    lblCardd2.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Dealer wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit2.Enabled = false;
                    this.btnStay2.Enabled = false;
                }
                //check to see if player1total equals 21 and display comments
                if (player1total == 21)
                {
                    this.lblComment.Text = Convert.ToString("BlackJack!! Player1 wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit2.Enabled = false;
                    this.btnStay2.Enabled = false;
                }
                //check to see if player2total equals 21 and display comments
                else if (player2total == 21)
                {
                    this.lblComment.Text = Convert.ToString("BlackJack!! Player2 wins");
                    this.lblComment.Show();
                }
                //check to see if dealerstotal equals 21 and display comments
                else if (dealerstotal == 21)
                {
                    lblCardd2.Show();
                    this.lblComment.Text = Convert.ToString("BlackJack!! Dealer wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                }
            }
            //using the amount of times the button is hit display the right amount of cards and totals
            else if (hitCount2 == 2)
            {
                player2total = cardpp1 + cardpp2 + cardpp3 + cardpp4;
                this.lblCardpp4.Show();
                lblP2total.Text = Convert.ToString(player2total);
                //check to see if player1total is over 21 and display comments
                if (player1total > 21)
                {
                    this.lblComment.Show();
                    lblPtotal.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Player1 loses");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    lblCardd2.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;



                }
                //check to see if player2total is over 21 and display comments
                else if (player2total > 21)
                {
                    this.lblComment.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Player2 loses");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit2.Enabled = false;
                    this.btnStay2.Enabled = false;
                }
                //check to see if dealerstotal is over 21 and display comments
                else if (dealerstotal > 21)
                {
                    this.lblComment.Show();
                    lblCardd2.Show();
                    this.lblComment.Text = Convert.ToString("Bust!! Dealer wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit2.Enabled = false;
                    this.btnStay2.Enabled = false;
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                }
                //check to see if player1total is equal 21 and display comments
                if (player1total == 21)
                {
                    this.lblComment.Text = Convert.ToString("BlackJack!! Player1 wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                    this.btnHit2.Enabled = false;
                    this.btnStay2.Enabled = false;
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                    
                }
                //check to see if player2total is equal 21 and display comments
                else if (player2total == 21)
                {
                    this.lblComment.Text = Convert.ToString("BlackJack!! Player2 wins");
                    this.lblComment.Show();
                    this.btnHit2.Enabled = false;
                    this.btnStay2.Enabled = false;
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                    
                }
                //check to see if dealerstotal is equal 21 and display comments
                else if (dealerstotal == 21)
                {
                    lblCardd2.Show();
                    this.lblComment.Text = Convert.ToString("BlackJack!! Dealer wins");
                    this.lblComment.Show();
                    lblPtotal.Show();
                    lblDtotal.Show();
                    lblP2total.Show();
                   
                }
            }
            //show or hide necessary labels
            this.lblCardpp3.Show();
            this.lblComment.Hide();
            lblDtotal.Hide();
            lblPtotal.Show();
            lblPtotal.Text = Convert.ToString(player1total);
            lblP2total.Show();
            //check to see if player1total is over 21 and display comments
            if (player1total > 21)
            {
                this.lblComment.Show();
                lblPtotal.Show();
                this.lblComment.Text = Convert.ToString("Bust!! Player1 loses");
                this.lblComment.Show();
                lblPtotal.Show();
                lblDtotal.Show();
                lblP2total.Show();
                lblCardd2.Show();
                this.btnHit2.Enabled = false;
                this.btnStay2.Enabled = false;



            }
            //check to see if player1total is over 21 and display comments
            else if (player2total > 21)
            {
                this.lblComment.Show();
                this.lblComment.Text = Convert.ToString("Bust!! Player2 loses");
                this.lblComment.Show();
                lblPtotal.Show();
                lblDtotal.Show();
                lblP2total.Show();
                this.btnHit2.Enabled = false;
                this.btnStay2.Enabled = false;
            }
            //check to see if dealerstotal is over 21 and display comments
            else if (dealerstotal > 21)
            {
                this.lblComment.Show();
                lblCardd2.Show();
                this.lblComment.Text = Convert.ToString("Bust!! Dealer wins");
                this.lblComment.Show();
                lblPtotal.Show();
                lblDtotal.Show();
                lblP2total.Show();
                this.btnHit2.Enabled = false;
                this.btnStay2.Enabled = false;
            }
            //check to see if player1total is equal 21 and display comments
            if (player1total == 21)
            {
                this.lblComment.Text = Convert.ToString("BlackJack!! Player1 wins");
                this.lblComment.Show();
                lblPtotal.Show();
                lblDtotal.Show();
                lblP2total.Show();
                this.btnHit2.Enabled = false;
                this.btnStay2.Enabled = false;
              
            }
            //check to see if player2total is equal 21 and display comments
            else if (player2total == 21)
            {
                this.lblComment.Text = Convert.ToString("BlackJack!! Player2 wins");
                this.lblComment.Show();
            }
            //check to see if dealertotal is equal 21 and display comments
            else if (dealerstotal == 21)
            {
                lblCardd2.Show();
                this.lblComment.Text = Convert.ToString("BlackJack!! Dealer wins");
                this.lblComment.Show();
                lblPtotal.Show();
                lblDtotal.Show();
                lblP2total.Show();
            }
            //enable and diable necessary buttons 
            this.btnHit.Enabled = false;
            this.btnStay.Enabled = false;
            this.btnHit2.Enabled = false;
            this.btnStay2.Enabled = false;
            lblCardd2.Show();
            this.btnHit.Enabled = true;
            this.btnStay.Enabled = true;
            //using the amount of times the button is clicked display the right amount of cards and the right total
           if(hitCount2==1)
            {
                lblCardd2.Show();
            }
            //using the amount of times the button is clicked display the right amount of cards and the right total
            if (hitCount2 == 2)
                if (dealerstotal < 17)
                {
                    this.lblCardd3.Show();
                    dealerstotal = cardd1 + cardd2 + cardd3;
                }
                else if (dealerstotal >= 17)
                {
                    dealerstotal = cardd1 + cardd2;
                }
            //using the amount of times the button is clicked display the right amount of cards and the right total
            if (hitCount==3)
            {
                if(dealerstotal< 17)
                {
                    this.lblCardd4.Show();
                    dealerstotal = cardd1 + cardd2 + cardd3 + cardd4;
                }
                else if (dealerstotal>= 17)
                {
                    dealerstotal = cardd1 + cardd2 + cardd3;
                }
            }


        }

        private void btnStay2_Click(object sender, EventArgs e)
        {
            //make an increament for the amount of times the button is clicked 
            stays2++;
            //enable and disable necessary buttons
            this.btnHit.Enabled = true;
            this.btnStay.Enabled = true;
            this.btnHit2.Enabled = false;
            this.btnStay2.Enabled = false;

            //using the amount of times the button is clicked display the right amount of cards and the right total
            if (stays2 == 1)
            {
                lblCardd2.Show();

            }
            //using the amount of times the button is clicked display the right amount of cards and the right total
            if (stays2 == 2)
            {
                if (dealerstotal < 17)
                {

                    this.lblCardd3.Show();
                    dealerstotal = cardd1 + cardd2 + cardd3;
                }
                else if (dealerstotal >= 17)
                {
                    dealerstotal = cardd1 + cardd2;
                }
                //using the amount of times the button is clicked display the right amount of cards and the right total
                if (stays2 == 3)
                {
                    if (dealerstotal < 17)
                    {

                        this.lblCardd4.Show();
                        dealerstotal = cardd1 + cardd2 + cardd3 + cardd4;
                    }
                    else if (dealerstotal >= 17)
                    {
                        dealerstotal = cardd1 + cardd2 + cardd3;
                    }


                }
            }
        }
    }
}


   


