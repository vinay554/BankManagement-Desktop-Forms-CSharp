using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    //this form gives details of interest for various types of accounts
    public partial class InterestDetails : Form
    {
        public InterestDetails()
        {
            InitializeComponent();
        }
        private static InterestDetails interestDetails;
        internal static InterestDetails GetInterestDetails()
        {
            //if no instance of form exists, then display the form
            if (interestDetails == null)
                interestDetails = new InterestDetails();
            return interestDetails;
        }//GetInterestDetails()

        private void InterestDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            interestDetails = null;
        }//form closing

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fixedDepositButton_Click(object sender, EventArgs e)
        {
            FixedAccount fixedAcc = new FixedAccount("Fixed Deposit Account", 8);

            string message = fixedAcc.showDetails(fixedAcc);
            message += $"We offer a Fixed deposit account with interest of 8%. We dont charge anything for this account.";
            resultLabel.Text = message;
        }

        private void currentAccountButton_Click(object sender, EventArgs e)
        {
            CurrentAccount currentAcc = new CurrentAccount("Current Account", 5);
            string message = currentAcc.showDetails(currentAcc);
            message += $"We offer a Current savings account with interest of 5%. We charge $10.99 per month for this account.";
            resultLabel.Text = message;
        }

        private void advanceSavingsbutton_Click(object sender, EventArgs e)
        {
            SavingsAccount savingsAcc = new SavingsAccount("Advance savings account", 10);
            string message = savingsAcc.showDetails(savingsAcc);
            message += $"We offer an advance savings account with interest of 5%. We charge $25 per month for this account.";
            resultLabel.Text = message;
        }
        
    }
}
