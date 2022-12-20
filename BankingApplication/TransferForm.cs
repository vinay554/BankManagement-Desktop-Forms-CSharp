using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BankingApplication
{
    //this form allows the customer to transfer amount between two accounts
    public partial class TransferForm : Form
    {
        BankDataClass bankData = new BankDataClass();
        string bal2;
        public TransferForm()
        {
            InitializeComponent();
            loaddate();
        }
        private static TransferForm transferForm;
        public static TransferForm GetTransferForm()
        {
            //to make the form a singleton form
            if (transferForm == null) transferForm = new TransferForm();
            return transferForm;
        }//GetTransferForm()
        private void loaddate()
        {
            dateLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }//loaddate()

        private void TransferForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //making the instance null when form closes
            transferForm = null;
        }//form closing

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

        private void getDetailsButton1_Click(object sender, EventArgs e)
        {
            string no = destAccTextBox.Text;
            string query = "SELECT * FROM UserAcc WHERE Account_No =" + no;
            var reader = bankData.GetReader(query, CommandType.Text);

            if (reader.Read())
            {
                destiNametextBox.Text = reader["Name"].ToString();
                bal2 = reader["Balance"].ToString();

            }
            else
            {
                MessageBox.Show("No record found for the given Account Number");
            }
            reader.Close();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            string date,fromname,toname;
            decimal bal, tra, fromacno, toacno,dbal;

            fromacno = decimal.Parse(accTextBox.Text);
            fromname = NameTextBox.Text;
            toacno = decimal.Parse(destAccTextBox.Text);
            toname = destiNametextBox.Text;
            date = dateLabel.Text;
            bal = decimal.Parse(oldBaltextBox.Text);
            tra = decimal.Parse(AmountTextBox.Text);
            dbal = decimal.Parse(bal2);


            if (bal >= tra)
            {
                BankIntermediary bankIntermediary = new BankIntermediary();
                try
                {
                    //passing all the input textbox values through Transfer() function
                    if (bankIntermediary.Transfer(fromacno,fromname,toacno,toname, bal,tra, date,dbal) != -1)

                    {
                        //display message is money is transferred
                        MessageBox.Show("Transferred successfully...");

                    }
                    else
                    {
                        //display a message if tranfser fails
                        MessageBox.Show("Transfer failed");
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
