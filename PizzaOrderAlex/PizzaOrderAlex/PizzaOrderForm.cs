/*
 * Created by: Alexandrea Udechukwu
 * Created on: 12-October-2019
 * Created for: ICS3U Programming
 * Assignment #4b - Pizza Order
 * This program gives the user choices of pizza sizes, toppings, 
 * fries and drinks. it also gives an option of provinces after which it calculates 
 * the subtotal, HST and total
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

namespace PizzaOrderAlex
{
    public partial class grbPizza : Form
    {
        public grbPizza()
        {
            InitializeComponent();
            //hide lsbels display prices on bulid
            this.lblCFries.Hide();
            this.lblCToppings.Hide();
            this.lblCDrinks.Hide();
            this.lblPizzaCost.Hide();
            this.lblCHST.Hide();
            this.lblCSubtotal.Hide();
            this.lblCTotal.Hide();
            this.lblHST.Hide();
            this.lblSubtotal.Hide();
            this.lblTotal.Hide();
        }
        //declear all global constants
        const double SMALLPIZZA =  4.99;
        const double MEDIUMPIZZA = 5.99;
        const double MEDIUMLARGEPIZZA = 7.99;
        const double LARGEPIZZA = 9.99;
        const double EXTRALARGEPIZZA = 12.99;
        const double EXTRAEXTRALARGEPIZZA = 15.99;
        const double ONETOPPING = .75;
        const double TWOTOPPPINGS = 1.35;
        const double THREETOPPINGS = 2.15;
        const double FOURTOPPINGS = 2.75;
        const double FIVETOPPINGS = 3.35;
        const double SIXTOPPINGS = 4.15;
        const double SMALLDRINK = 2.10;
        const double MEDIUMDRINK = 2.50;
        const double LARGEDRINK = 3.10;
        const double EXTRALARGEDRINK = 3.50;
        const double SMALLFRIES = 1.39;
        const double MEDIUMFRIES = 1.99;
        const double LARGEFRIES = 2.10;
        const double EXTRALARGEFRIES = 2.50;
        const double ALBERTATAX = 0.05;
        const double ONTARIOTAX = 0.13;

        
        double subtotal = 0;
        double HST = 0;
        double total = 0 ;
       

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //declear all local variables
           double pizzaSize, toppings, drinks, fries, pizzaCost, toppingCost, drinksCost, FriesCost;


            pizzaSize = double.Parse(nudPizza.Text);
            toppings = double.Parse(nudToppings.Text);
            drinks = double.Parse(nudDrink.Text);
            fries = double.Parse(nudFries.Text);
            // variables
            pizzaCost = 0;
            toppingCost = 0;
            FriesCost = 0;
            drinksCost = 0;
            HST = 0;
            //get size of pizza
            if (pizzaSize==1)
            {
                pizzaCost = SMALLPIZZA;
                lblPizzaCost.Text = Convert.ToString(pizzaCost);
                lblPizzaCost.Text= String.Format("${0:0.00}", pizzaCost);
                this.lblPizzaCost.Show();
            }
            else if (pizzaSize==2)
            {
                pizzaCost = MEDIUMPIZZA;
                lblPizzaCost.Text = Convert.ToString(pizzaCost);
                lblPizzaCost.Text = String.Format("${0:0.00}", pizzaCost);
                this.lblPizzaCost.Show();
            }
            else if (pizzaSize==3)
            {
                pizzaCost = MEDIUMLARGEPIZZA;
                lblPizzaCost.Text = Convert.ToString(pizzaCost);
                lblPizzaCost.Text = String.Format("${0:0.00}", pizzaCost);
                this.lblPizzaCost.Show();
            }
            else if (pizzaSize == 4)
            {
                pizzaCost = LARGEPIZZA;
                lblPizzaCost.Text = Convert.ToString(pizzaCost);
                lblPizzaCost.Text = String.Format("${0:0.00}", pizzaCost);
                this.lblPizzaCost.Show();
            }
            else if (pizzaSize == 5)
            {
                pizzaCost =EXTRALARGEPIZZA;
                lblPizzaCost.Text = Convert.ToString(pizzaCost);
                lblPizzaCost.Text = String.Format("${0:0.00}", pizzaCost);
                this.lblPizzaCost.Show();
            }
            else if (pizzaSize == 6)
            {
                pizzaCost = EXTRAEXTRALARGEPIZZA;
                lblPizzaCost.Text = Convert.ToString(pizzaCost);
                lblPizzaCost.Text = String.Format("${0:0.00}", pizzaCost);
                this.lblPizzaCost.Show();
            }
            //get number of toppings
            if (toppings == 1)
            {
                toppingCost = ONETOPPING;
                lblCToppings.Text = Convert.ToString(toppingCost);
                lblCToppings.Text = String.Format("${0:0.00}", toppingCost);
                this.lblCToppings.Show();
            }
            else if (toppings == 2)
            {
                toppingCost = TWOTOPPPINGS;
                lblCToppings.Text = Convert.ToString(toppingCost);
                lblCToppings.Text = String.Format("${0:0.00}", toppingCost);
                this.lblCToppings.Show();
            }
            else if (toppings == 3)
            {
                toppingCost = THREETOPPINGS;
                lblCToppings.Text = Convert.ToString(toppingCost);
                lblCToppings.Text = String.Format("${0:0.00}", toppingCost);
                this.lblCToppings.Show();
            }
            else if (toppings == 4)
            {
                toppingCost = FOURTOPPINGS;
                lblCToppings.Text = Convert.ToString(toppingCost);
                lblCToppings.Text = String.Format("${0:0.00}", toppingCost);
                this.lblCToppings.Show();
            }
            else if (toppings == 5)
            {
                toppingCost = FIVETOPPINGS;
                lblCToppings.Text = Convert.ToString(toppingCost);
                lblCToppings.Text = String.Format("${0:0.00}", toppingCost);
                this.lblCToppings.Show();
            }
            else if (toppings == 6)
            {
                toppingCost = SIXTOPPINGS;
                lblCToppings.Text = Convert.ToString(toppingCost);
                lblCToppings.Text = String.Format("${0:0.00}", toppingCost);
                this.lblCToppings.Show();
            }
            //get if user wants fries and if yes get size
            if (fries == 0)
            {
                FriesCost = 0;
                lblCFries.Text = Convert.ToString(FriesCost);
                lblCFries.Text = String.Format("${0:0.00}", FriesCost);
                this.lblCFries.Show();
            }
            else if (fries == 1)
            {
                FriesCost = SMALLFRIES;
                lblCFries.Text = Convert.ToString(FriesCost);
                lblCFries.Text = String.Format("${0:0.00}", FriesCost);
                this.lblCFries.Show();
            }
            else if (fries == 2)
            {
                FriesCost = MEDIUMFRIES;
                lblCFries.Text = Convert.ToString(FriesCost);
                lblCFries.Text = String.Format("${0:0.00}", FriesCost);
                this.lblCFries.Show();
            }
            else if (fries == 3)
            {
                FriesCost =LARGEFRIES;
                lblCFries.Text = Convert.ToString(FriesCost);
                lblCFries.Text = String.Format("${0:0.00}", FriesCost);
                this.lblCFries.Show();
            }
            else if (fries == 4)
            {
                FriesCost = EXTRALARGEFRIES;
                lblCFries.Text = Convert.ToString(FriesCost);
                lblCFries.Text = String.Format("${0:0.00}", FriesCost);
                this.lblCFries.Show();
            }
            //get if user wants a drink and if yes get size
            if (drinks == 0)
            {
                drinksCost = 0;
                lblCDrinks.Text = Convert.ToString(drinksCost);
                lblCDrinks.Text = String.Format("${0:0.00}", drinksCost);
                this.lblCDrinks.Show();
            }
            else if (drinks == 1)
            {
                drinksCost = SMALLDRINK;
                lblCDrinks.Text = Convert.ToString(drinksCost);
                lblCDrinks.Text = String.Format("${0:0.00}", drinksCost);
                this.lblCDrinks.Show();
            }
            else if (drinks == 2)
            {
                drinksCost = MEDIUMDRINK;
                lblCDrinks.Text = Convert.ToString(drinksCost);
                lblCDrinks.Text = String.Format("${0:0.00}", drinksCost);
                this.lblCDrinks.Show();
            }
            else if (drinks == 3)
            {
                drinksCost = LARGEDRINK;
                lblCDrinks.Text = Convert.ToString(drinksCost);
                lblCDrinks.Text = String.Format("${0:0.00}", drinksCost);
                this.lblCDrinks.Show();
            }
            else if (drinks == 4)
            {
                drinksCost = EXTRALARGEDRINK;
                lblCDrinks.Text = Convert.ToString(drinksCost);
                lblCDrinks.Text = String.Format("${0:0.00}", drinksCost);
                this.lblCDrinks.Show();
            }
            //calculate subtotal
            subtotal = pizzaCost + toppingCost + FriesCost + drinksCost;
            lblCSubtotal.Text = Convert.ToString(subtotal);
            lblCSubtotal.Text = String.Format("${0:0.00}", subtotal);
            this.lblCSubtotal.Show();
            this.lblSubtotal.Show();

            //get users province and calculate tax
            if (radOntario.Checked== true)
            {
                HST = ONTARIOTAX * subtotal;
                lblCHST.Text = Convert.ToString(HST);
                lblCHST.Text = String.Format("${0:0.00}", HST);
                this.lblCHST.Show();
                this.lblHST.Show();
            }
            else if(radAlberta.Checked== true)
            {
                HST = ALBERTATAX * subtotal;
                lblCHST.Text = Convert.ToString(HST);
                lblCHST.Text = String.Format("${0:0.00}", HST);
                this.lblCHST.Show();
                this.lblHST.Show();
            }
            //calculate total
            total = subtotal + HST;
            lblCTotal.Text = Convert.ToString(total);
            lblCTotal.Text = String.Format("${0:0.00}", total);
            this.lblTotal.Show();
            this.lblCTotal.Show();








            



        }

       
    }

    
 }

