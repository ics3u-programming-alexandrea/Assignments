using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSimplified21
{
    public partial class frmNewSimplified21 : Form
    {
        List<Image> listCardImages = new List<Image>();    
        public frmNewSimplified21()
        {
            InitializeComponent();
        }

        private void frmNewSimplified21_Load(object sender, EventArgs e)
        {
            this.lblPlayers.Hide();
            this.lblPtotal.Hide();
            this.lblDealers.Hide();
            this.lblDtotal.Hide();
            this.btnNewRound.Hide();
            this.btnHit.Hide();
            this.btnStay.Hide();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
