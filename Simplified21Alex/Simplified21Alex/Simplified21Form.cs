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
        int PlayerCardValue = 0;
        int dealerCardValue = 0;
        Random cardGenerator = new Random();
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 11;




        public frmSimplified21()

        {
            PlayerCardValue = cardGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            InitializeComponent();
                  dealerCardValue -= 10;
            }

         

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void btnHit_Click(object sender, EventArgs e)
        {
          

        

        }

        private void LblWinner_Click(object sender, EventArgs e)
        {

        }
    }
}
