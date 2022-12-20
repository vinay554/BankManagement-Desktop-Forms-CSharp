using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    //this form allows the customer to create a new account 
    public partial class newAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        BankDataClass bankData;
        MemoryStream ms;



        private newAccount()
        {
            InitializeComponent();
            loaddate();
            loadAccount();
            
        }
        private static newAccount newaccount;
        internal static newAccount GetNewAccount()
        {
            //if no instance of form exists, then display the form
            if (newaccount == null) 
                newaccount = new newAccount();
            return newaccount;
        }//GetNewAccount()

        private void newAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            newaccount = null;
        }//form closing

        private void loaddate()
        {
            dateLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }//loaddate()


        private void loadAccount()
        {
            //get the maximum account number and increment it by one and display in create account form
            bankData = new BankDataClass();
            var item = bankData.ExecuteScalarQuery("SELECT Account_No FROM UserAcc WHERE Account_No = (SELECT MAX(Account_No) FROM UserAcc);", CommandType.Text);
            no = Convert.ToInt32(item) + 1;
            accountLabel.Text = Convert.ToString(no);
        }//loadAccount()



        private void NewAccount_Load(object sender, EventArgs e)
        {

        }

      
      
        private void saveButton_Click(object sender, EventArgs e)
        {
            //this button should create an account based on customer entered data
            //for radio buttons,based on selected button, assign a value to load into the data table
            if (maleRadio.Checked)
            {
                gender = "male";
            }
            else if (femaleRadio.Checked)
            {
                gender = "female";
            }
            else if (otherRadio.Checked)
            {
                gender = "other";
            }
            if (marriedRadio.Checked)
            {
                m_status = "married";
            }
            else if (unmarriedRadio.Checked)
            {
                m_status = "unmarried";
            }

            BankIntermediary bankIntermediary = new BankIntermediary();
            decimal acc;
            decimal bal;

            try
            {
                if(Decimal.TryParse(accountLabel.Text, out acc) && acc >= 100)
                {
                    errorProvider1.SetError(accountLabel, "");

                    if (!string.IsNullOrEmpty(nameTextBox.Text))
                    {
                        errorProvider1.SetError(nameTextBox, "");

                        if (!string.IsNullOrEmpty(phoneTextBox.Text))
                        {
                            errorProvider1.SetError(phoneTextBox, "");
                            if (!string.IsNullOrEmpty(addressTextBox.Text))
                            {
                                errorProvider1.SetError(addressTextBox, "");
                                if (!string.IsNullOrEmpty(cityTextBox.Text))
                                {
                                    errorProvider1.SetError(cityTextBox,"");
                                    if (!string.IsNullOrEmpty(stateTextBox.Text))
                                    {
                                        errorProvider1.SetError(stateTextBox, "");
                                        if(maleRadio.Checked==true || femaleRadio.Checked == true || otherRadio.Checked == true)
                                        {
                                            errorProvider1.SetError(otherRadio, "");
                                            if (marriedRadio.Checked == true || unmarriedRadio.Checked == true)
                                            {
                                                errorProvider1.SetError(marriedRadio, "");
                                                if (!string.IsNullOrEmpty(motherTextBox.Text))
                                                {
                                                    errorProvider1.SetError(motherTextBox, "");
                                                    if (!string.IsNullOrEmpty(fatherTextBox.Text))
                                                    {
                                                        errorProvider1.SetError(fatherTextBox, "");
                                                        if(Decimal.TryParse(accountLabel.Text, out bal) && bal >= 0)
                                                        {
                                                            errorProvider1.SetError(balanceTextBox, "");
                                                            if (bankIntermediary.AddCustomer(acc, nameTextBox.Text, dateTimePicker1.Value, phoneTextBox.Text, addressTextBox.Text, cityTextBox.Text, stateTextBox.Text, gender, m_status, motherTextBox.Text, fatherTextBox.Text, Convert.ToDecimal(balanceTextBox.Text), dateLabel.Text) != -1)

                                                            {
                                                                //display a message when an a record is added to the table
                                                                MessageBox.Show("Customer record added successfully...");
                                                            }
                                                            else
                                                            {
                                                                //display message if data upload fails
                                                                MessageBox.Show("Database updation failed");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            errorProvider1.SetError(balanceTextBox, "Enter initial deposit amount");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        errorProvider1.SetError(fatherTextBox, "Enter father name");
                                                    }
                                                }
                                                else
                                                {
                                                    errorProvider1.SetError(motherTextBox, "Enter Mother name");
                                                }
                                            }
                                            else
                                            {
                                                errorProvider1.SetError(marriedRadio, "Choose marital status");
                                            }
                                        }
                                        else
                                        {
                                            errorProvider1.SetError(otherRadio, "Select Gender");
                                        }
                                    }
                                    else
                                    {
                                        errorProvider1.SetError(stateTextBox, "State field cannot be empty");
                                    }
                                }
                                else
                                {
                                    errorProvider1.SetError(cityTextBox, "City field cannot be empty");
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(addressTextBox, "Address field cannot be empty");
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(phoneTextBox, "Phone number cannot be empty");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(nameTextBox, "Name cannot be empty");
                    }
                }
                else
                {
                    errorProvider1.SetError(accountLabel, "Account number must be greater than 100");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }//saveButton_Click()
    }
}
