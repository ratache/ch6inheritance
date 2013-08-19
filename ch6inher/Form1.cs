using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch6inher
{
    public partial class Form1 : Form
    {
        BirthdayParty birthdayParty;
        DinnerParty dinnerParty;

        public Form1()
        {
            //INIT
            InitializeComponent();
            
            //Init dinnerparty interface
            dinnerParty = new DinnerParty(1, cbDinnerFancy.Checked, cbDinnerHealthy.Checked);
            DisplayDinnerPartyCost();

            //Init birthdayparty interface
            birthdayParty = new BirthdayParty(1, cbBirthdayFancy.Checked, tbCakeWrit.Text);
            DisplayBirthdayPartyCost();

        }

        //Eventhandlers
        private void numericUnDdinner_ValueChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void cbDinnerFancy_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void cbDinnerHealthy_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void tbCakeWrit_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = tbCakeWrit.Text;
            DisplayBirthdayPartyCost();
        }

        private void numUnDBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numUnDBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void cbBirthdayFancy_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostofDecor(cbBirthdayFancy.Checked);
            DisplayBirthdayPartyCost();
        }

        //Updates gui
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost((int)numericUnDdinner.Value, cbDinnerHealthy.Checked, cbDinnerFancy.Checked);
            labelCost.Text = Cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            tbCakeWrit.Text = birthdayParty.CakeWriting;
            decimal cost = birthdayParty.CalculateCost();
            lblCostBirthday.Text = cost.ToString("c");

        }

    }
}
