using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    //this form allows the customer to deposit an amount into his account
    public partial class DepositForm : Form
    {
        BankDataClass bankData = new BankDataClass();
        public DepositForm()
        {
            InitializeComponent();
            loaddate();
        }
        private static DepositForm depositform;
        public static DepositForm GetDepositForm()
        {
            //to make the form a singleton form
            if (depositform == null) depositform = new DepositForm();
            return depositform;
        }//GetDepositForm()

        private void DepositForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //making the instance null when form closes
            depositform = null;
        }//form closing
        private void loaddate()
        {
            dateLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }//loaddate()

        private void getDetailsButton_Click(object sender, EventArgs e)
        {
            //get the account number from textbox and pass it through a query
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
                //display a message if no account is found
                MessageBox.Show("No record found for the given Account Number");
            }
            reader.Close();

        }//getDetailsButton_Click()

        private void updateButton_Click(object sender, EventArgs e)
        {
            //declaring variables to hold the input data
            string  date, mode, name;
            decimal bal, dep, acno;

            acno = decimal.Parse(accTextBox.Text);
            name = NameTextBox.Text;
            date = dateLabel.Text;
            bal = decimal.Parse(oldBaltextBox.Text);
            dep = decimal.Parse(depositTextBox.Text);
            if(modeComboBox.SelectedIndex == 0)
            {
                mode = "Cash";
            }
            else
            {
                mode = "Cheque";
            }

            BankIntermediary bankIntermediary = new BankIntermediary();
            try
            {
               //passing all the input textbox values through deposit() function
                if (bankIntermediary.Deposit(acno, name, bal, mode, dep, date) != -1)

                {
                    //display message is money is deposited
                    MessageBox.Show("Customer account deposited successfully...");

                }
                else
                {
                    //display a message if deposit fails
                    MessageBox.Show("Deposit failed");
                }
            }//try
            catch (Exception ex)
            {
                throw ex;
            }//catch

           
        }//updateButton_Click()
    }
}
