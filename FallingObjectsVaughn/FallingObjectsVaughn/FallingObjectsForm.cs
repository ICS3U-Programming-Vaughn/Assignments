/*
 * Created by: Vaughn Donohue
 * Created on: 28-February-2020
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Objects
 * This program...
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

namespace FallingObjectsVaughn
{
    public partial class FallingObjectsForm : Form
    {
        public FallingObjectsForm()
        {
            InitializeComponent();
        }

        private void LblAnswer_Click(object sender, EventArgs e)
        {
            //when calculate button is pressed this outputs the answer
            this.lblOutput.Hide();
            this.lblOutput.Show();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            {

            }

            {
                // declare local variables
                double time, height;

                // convert the string from each text box to a double
                time = double.Parse(txtTime.Text);

                // calculate the circumference
                height = 100 - 0.5 * 9.8 * Math.Pow(time, 2);

                // insert the circumference into the respective label
                this.lblOutput.Text = Convert.ToString(height) + " meters";

                // display the circumference label with the respective answer
                this.lblOutput.Show();
            }

            
        }
    }
}
