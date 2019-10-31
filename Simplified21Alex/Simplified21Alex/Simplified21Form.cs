using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Simplified21Alex
{
    public partial class frmSimplified21 : Form

    {
        bool turnp1= false;
        bool turnp2 =false;
        bool turnd = false;
        //declear global variables
        const int MAX_VALUE = 11;
        const int MIN_VALUE = 1;
        Random numberGenerator = new Random();
       
        int cardp1;
        int cardp2;
        int cardp3;
        int cardp4;
        int cardpp1;
        int cardpp2;
        int cardpp3;
        int cardd1;
        int cardd2;
        int cardd3;
        int player1total;
        int player2total;
        int dealerstotal;

        public frmSimplified21()
        {
            InitializeComponent();
            lblPlayers.Hide();
            lblPlayer2.Hide();
            lblP2total.Hide();
            lblDealers.Hide();
            lblPtotal.Hide();
            lblDtotal.Hide();
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
            this.btnHit.Hide();
            this.btnStay.Hide();
            this.lblComment.Hide();
          
        }
        

        private void btnStart_Click_1(object sender, EventArgs e)
        {


            this.lblBlackjack.Hide();
            this.Refresh();

            lblPlayers.Show();
            this.btnHit.Show();
            this.btnStay.Show();
            this.lblCardd1.Show();
            this.lblPlayer2.Show();


            lblDealers.Show();
            this.lblCardp1.Show();
            this.lblCardp2.Show();
            this.lblCardpp1.Show();
            this.lblCardpp2.Show();

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

            cardd1 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardd1.Text = Convert.ToString(cardd1);
            cardd2 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardd2.Text = Convert.ToString(cardd2);
            cardd3 = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblCardd3.Text = Convert.ToString(cardd3);
            player1total = cardp1 + cardp2;
            lblPtotal.Text = Convert.ToString(player1total);
            player2total = cardpp1 + cardpp2;
            lblP2total.Text = Convert.ToString(player2total);
            dealerstotal = cardd1 + cardd2;
            lblDtotal.Text = Convert.ToString(dealerstotal);

            if(player1total>21)
            {
                this.lblComment.Text = Convert.ToString("Bust!! Player1 loses");
            }
            else if(player2total > 21)
            {
                this.lblComment.Text = Convert.ToString("Bust!! Player2 loses");
            }
            else if(dealerstotal<21)
            {
                this.lblComment.Text = Convert.ToString("Bust!! Dealer wins");
            }

            if (turnp1 == true )
            {
                this.btnHit.Enabled= true;
            }
            else
            {
                this.btnHit.Enabled = false;
            }
            if(turnd==true)
            {
               

            }
            if(turnp2==true)
            {

            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //this will exit the form
            this.Close();
        }

        private void btnHit_Click_1(object sender, EventArgs e)
        {
            if (player1total > 21)
            {
                this.lblComment.Text = Convert.ToString("Bust!! Player1 loses");
            }
            else if (player2total > 21)
            {
                this.lblComment.Text = Convert.ToString("Bust!! Player2 loses");
            }
            else if (dealerstotal < 21)
            {
                this.lblComment.Text = Convert.ToString("Bust!! Dealer wins");
            }
            if (player1total == 21)
            {
                this.lblComment.Text = Convert.ToString("BlackJack!! Player1 wins");
            }
            else if (player2total == 21)
            {
                this.lblComment.Text = Convert.ToString("BlackJack!! Player2 wins");
            }
            else if (dealerstotal == 21)
            {
                this.lblComment.Text = Convert.ToString("BlackJack!! Dealer wins");
            }
            else
            {
                this.lblCardp3.Show();
                
            }
           
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The aim of the game is to get close to or exactly 21 without going over. At the and of the game the totals are display" +
                "and then if no play gets exactly 21, the Player who is closest to 21 wins", "Blackjack By Alex");
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            player1total = cardp1 + cardp2 +cardp3;
            lblPtotal.Text = Convert.ToString(player1total);
            player2total = cardpp1 + cardpp2;
            lblP2total.Text = Convert.ToString(player2total);
            dealerstotal = cardd1 + cardd2;
            lblDtotal.Text = Convert.ToString(dealerstotal);
            this.lblP2total.Show();
            this.lblPtotal.Show();
            this.lblDtotal.Show();

        }
    }
}

   


