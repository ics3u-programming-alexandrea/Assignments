using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderAlex
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
            //hide lsbels display prices on bulid
            this.lblCHST.Hide();
            this.lblCSubtotal.Hide();
            this.lblCTotal.Hide();
            this.lblHST.Hide();
            this.lblSubtotal.Hide();
            this.lblTotal.Hide();
        }
        const double SMALLPIZZA =  4.99;
        const double MEDIUMPIZZA = 5.99;
        const double MEDIUMLARGEPIZZA = 7.99;
        const double LARGEPIZZA = 9.99;
        const double EXTRALARGEPIZZA = 12.99;
        const double EXTRAEXTRALARGEPIZZA = 15.99;
        const double ONETOPPINGS = .75;
        const double TWOTOPPPINGS = 1.35;
        const double THREETOPPINGS = 2.15;
        const double FOURTOPPINGS = 2.75;
        const double FIVETOPPINGS = 3.35;
        const double SIXTOPPINGS = 4.15;
        const double SMALLDRINK = 2.10;
        const double MEDIUMDRINK = 2.50;
        const double LARGEDRINK = 3.10;
        const double EXTRALARGEDRINK = 3.50;
        


        const double ALBERTATAX = 1.05;
        const double ONTARIOTAX = 1.13;

        //total = subtotal + subtotal * 0.13
        double subtotal = 0;
        double total = 0 ;

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
          
        }
    }

    
 }

