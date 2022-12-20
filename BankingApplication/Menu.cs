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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        //making this from MDI parent to all other forms
        //new account opening
        private void newAccountOpeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newAccount newacc = newAccount.GetNewAccount();
            newacc.MdiParent = this;
            newacc.Show();
        }
        //update account form
        private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updation_form update = updation_form.GetUpdationForm();
            update.MdiParent = this;            
            update.Show();
        }
        //show all customers form
        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allCustomersform allcustomersform = allCustomersform.GetCustomersForm();
            allcustomersform.MdiParent = this;
            allcustomersform.Show();
        }
        //deposit form
        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositForm df = DepositForm.GetDepositForm();
            df.MdiParent = this;
            df.Show();
        }
        //withdraw form
        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawForm wf = WithdrawForm.GetWithdrawForm();
            wf.MdiParent = this;
            wf.Show();    
        }
        //transfer form
        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm tf = TransferForm.GetTransferForm();
            tf.MdiParent = this;
            tf.Show();
        }

        private void fixedDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FixedDepositForm fdform = new FixedDepositForm();
            fdform.MdiParent = this;
            fdform.Show();
        }
        //logout button to close the application
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //exit button to close the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //about box to contain details of all the bank
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passwordChangeForm passform = new passwordChangeForm();
            passform.MdiParent = this;
            passform.Show();    
        }

      

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        //currency converter form
        private void currencyConvertorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyConverter currencyConverter = CurrencyConverter.GetCurrencyConverter();
            currencyConverter.MdiParent = this;
            currencyConverter.Show();
        }

        private void resourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = AboutBox.GetAboutBox();
            aboutBox.MdiParent = this;
            aboutBox.Show();
        }
        

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void bankToBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBalance viewbalance = ViewBalance.GetViewBalance();
            viewbalance.MdiParent = this;   
            viewbalance.Show();
        }

        private void staffDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffDetails staffDetails = StaffDetails.GetStaffDetails();
            staffDetails.MdiParent = this;
            staffDetails.Show();
        }

        private void interestDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterestDetails intDetails = InterestDetails.GetInterestDetails();
            intDetails.MdiParent = this;
            intDetails.Show();
        }
    }
 }

