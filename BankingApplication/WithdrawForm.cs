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
    //this form allows the customer to withdraw a sum from his account
    public partial class WithdrawForm : Form
    {
        BankDataClass bankData = new BankDataClass();
        public WithdrawForm()
        {
            InitializeComponent();
            loaddate();
        }
        private static WithdrawForm withdrawForm;
        public static WithdrawForm GetWithdrawForm()
        {
            //to make the form a singleton form
            if (withdrawForm == null) withdrawForm = new WithdrawForm();
            return withdrawForm;
        }//GetWithdrawForm()
        private void withdrawForm_Load(object sender, EventArgs e)
        {

        }

        private void WithdrawForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //making the instance null when form closes
            withdrawForm = null;
        }//form closing
        private void loaddate()
        {
            dateLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }//loaddate()

        private void getDetailsButton_Click(object sender, EventArgs e)
        {
            //declaring a variable to hold the account number from text box
            //Then passing the variable along with Sql query 
            string no = accTextBox.Text;
            string query = "SELECT * FROM UserAcc WHERE Account_No =" + no;
            var reader = bankData.GetReader(query, CommandType.Text);

            //validation to make sure the account is found
            if (reader.Read())
            {
                //The record exists
                NameTextBox.Text = reader["Name"].ToString();

                oldBaltextBox.Text = reader["Balance"].ToString();

            }
            else
            {
                //the record does not exist
                MessageBox.Show("No record found for the given Account Number");
            }
            reader.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            //declaring variables to hold the input data
            string date, mode, name;
            decimal bal, deb, acno;

            acno = decimal.Parse(accTextBox.Text);
            name = NameTextBox.Text;
            date = dateLabel.Text;
            bal = decimal.Parse(oldBaltextBox.Text);
            deb = decimal.Parse(withdrawTextBox.Text);
            if (modeComboBox.SelectedIndex == 0)
            {
                mode = "Cash";
            }
            else
            {
                mode = "Cheque";
            }

            if(bal >= deb)
            {
                BankIntermediary bankIntermediary = new BankIntermediary();
                try
                {
                    //passing all the input textbox values through Withdraw() function
                    if (bankIntermediary.Withdraw(acno, name, bal, mode, deb, date) != -1)

                    {
                        //display message is money is withdrawn
                        MessageBox.Show("Customer account withdrawn successfully...");

                    }
                    else
                    {
                        //display a message if withdraw fails
                        MessageBox.Show("Withdraw failed");
                    }
                }//try
                catch (Exception ex)
                {
                    throw ex;
                }//catch
            }
            else
            {
                MessageBox.Show("Insufficient account balance to complete this transaction");
            }
            

        }
    }
}
