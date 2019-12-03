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
       

    }
}
