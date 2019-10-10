/*
 * Created by: Alexandrea Udechukwu
 * Created on: 20-September-2019
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Objects
 * This program calculates the height an object is from the ground when
  a certain time is entered in the textbox and when the calculate button is clicked.
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

namespace FallingObjectsAlex
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
        }

        private void FallingObjectsAlexForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnTime_Click(object sender, EventArgs e)
        {

        }

        private void Btncalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double time, answer;

         
            //convert string from each textbox to a double
            time = double.Parse(txtTime.Text);

            //calculate height of the object above the ground
            answer = 100 - 0.5 * 9.81 * Math.Pow(time, 2);

            //display the height label with its respective answers
            this.lblAnswer.Show();
            this.lblAnswer.Text = Convert.ToString(answer);
            this.lblAnswer.Text = Convert.ToString(answer) + "metres";

            //if answer lower than zero
            if (answer < 0)
            {
                this.lblAnswer.Text="the object has already hit the ground";
                //if time is lower than zero
                if (time < 0)
                    this.lblAnswer.Text = "Please use only positive numbers";
               
            } 

     
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
