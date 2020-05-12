using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21Vaughn
{
    public partial class frmSimplified21 : Form
    {
        // Declare global constants
        const int MIN = 1;
        const int MAX = 11;
        //Declare global variables
        Random randomNumGenerator = new Random();
        int DealerCard1 = 0;
        int DealerCard2 = 0;
        int DealerCard3 = 0;
        int DealerTotal = 0;
        
        int PlayerCard1 = 0;
        int PlayerCard2 = 0;
        int PlayerCard3 = 0;
        int PlayerTotal = 0;
        public frmSimplified21()
        {
            InitializeComponent();
            this.btnHit.Enabled = false;
            this.btnStay.Enabled = false;
            this.btnPlayerTotal.Enabled = false;
        
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mniNewGame_Click(object sender, EventArgs e)
        {
            this.btnHit.Enabled = true;
            this.btnStay.Enabled = true;
            this.btnPlayerTotal.Enabled = true;

            //Give dealer 3 random cards between 1-10
            DealerCard1 = randomNumGenerator.Next(MIN, MAX + 1);
            DealerCard2 = randomNumGenerator.Next(MIN, MAX + 1);
            DealerCard3 = randomNumGenerator.Next(MIN, MAX + 1);

            //Give the player 2 random cards between 1-10
            PlayerCard1 = randomNumGenerator.Next(MIN, MAX + 1);
            PlayerCard2 = randomNumGenerator.Next(MIN, MAX + 1);
            this.lblPlayerCard1.Text = Convert.ToString(PlayerCard1);
            this.lblPlayerCard2.Text = Convert.ToString(PlayerCard2);
           
            //Hide the player's 3rd card, depending on if they choose to hit or stay
            this.lblPlayerCard3.Hide();

            //change the player's total and display 
            PlayerTotal = PlayerCard1 + PlayerCard2;
            lblPlayerTotal.Text = Convert.ToString(PlayerTotal);

        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            //player get's 3rd card
            PlayerCard3 = randomNumGenerator.Next(MIN, MAX + 1);
            this.lblPlayerCard3.Text = Convert.ToString(PlayerCard3);
           
            //display 3rd card
            this.lblPlayerCard3.Show();
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            //display dealer's cards
            this.lblDealerCard1.Text = Convert.ToString(DealerCard1);
            this.lblDealerCard2.Text = Convert.ToString(DealerCard2);
            this.lblDealerCard3.Text = Convert.ToString(DealerCard3);

            //calculate the dealers total 
            DealerTotal = DealerCard1 + DealerCard2 + DealerCard3;
            lblDealerTotal.Text = Convert.ToString(DealerTotal);
           
        }

        private void btnPlayerTotal_Click(object sender, EventArgs e)
        {
            PlayerTotal = PlayerCard1 + PlayerCard2 + PlayerCard3;
            lblPlayerTotal.Text = Convert.ToString(PlayerTotal);
            this.btnHit.Enabled = false;
        }
    }
    }

