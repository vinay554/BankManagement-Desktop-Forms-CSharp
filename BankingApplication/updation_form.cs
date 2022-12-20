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
    //this form allows the customer to update his account details 
    public partial class updation_form : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        string bal;
        BankDataClass bankData = new BankDataClass();
        public updation_form()
        {
            InitializeComponent();
            loaddate();
        }
        private static updation_form updationform;
        public static updation_form GetUpdationForm()
        {
            if (updationform == null) updationform = new updation_form();
            return updationform;
        }//GetUpdationForm()

        private void updation_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            updationform = null;
        }//form closing
        private void loaddate()
        {
            dateLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }//loaddate()


        private void button4_Click(object sender, EventArgs e)
        {
            //declaring a variable to hold the account number from text box
            //Then passing the variable along with Sql query  
            string no = accTextBox.Text;
            string query = "SELECT * FROM UserAcc WHERE Account_No =" + no;
            var reader = bankData.GetReader(query, CommandType.Text);

            // validation to make sure the account is found
            if (reader.Read())
            {
                //The record exists
                nameTextBox.Text = reader["Name"].ToString();
                motherTextBox4.Text = reader["Mother_name"].ToString();
                fatherTextBox5.Text = reader["Father_Name"].ToString();
                PhoneTextBox6.Text = reader["PhoneNO"].ToString();
                addressTextBox7.Text = reader["Address"].ToString();
                CitytextBox8.Text = reader["City"].ToString();
                StateTextBox9.Text = reader["state"].ToString();
                bal = reader["Balance"].ToString();

            }
            else
            {
                //The record does not exist
                MessageBox.Show("No record found for the given Account Number");
            }
            reader.Close(); 
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
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


            try
            {
                decimal acc;
                Decimal.TryParse(accTextBox.Text, out acc);

                if (Decimal.TryParse(accTextBox.Text, out acc) && acc >= 100)
                {
                    errorProvider1.SetError(accTextBox, "");

                    if (!string.IsNullOrEmpty(nameTextBox.Text))
                    {
                        errorProvider1.SetError(nameTextBox, "");

                        if (!string.IsNullOrEmpty(PhoneTextBox6.Text))
                        {
                            errorProvider1.SetError(PhoneTextBox6, "");
                            if (!string.IsNullOrEmpty(addressTextBox7.Text))
                            {
                                errorProvider1.SetError(addressTextBox7, "");
                                if (!string.IsNullOrEmpty(CitytextBox8.Text))
                                {
                                    errorProvider1.SetError(CitytextBox8, "");
                                    if (!string.IsNullOrEmpty(StateTextBox9.Text))
                                    {
                                        errorProvider1.SetError(StateTextBox9, "");
                                        if (maleRadio.Checked == true || femaleRadio.Checked == true || otherRadio.Checked == true)
                                        {
                                            errorProvider1.SetError(otherRadio, "");
                                            if (marriedRadio.Checked == true || unmarriedRadio.Checked == true)
                                            {
                                                errorProvider1.SetError(marriedRadio, "");
                                                if (!string.IsNullOrEmpty(motherTextBox4.Text))
                                                {
                                                    errorProvider1.SetError(motherTextBox4, "");
                                                    if (!string.IsNullOrEmpty(fatherTextBox5.Text))
                                                    {
                                                        errorProvider1.SetError(fatherTextBox5, "");

                                                        if (bankIntermediary.ModifyCustomer(acc, nameTextBox.Text, dateTimePicker2.Value, PhoneTextBox6.Text, addressTextBox7.Text, CitytextBox8.Text, StateTextBox9.Text, gender, m_status, motherTextBox4.Text, fatherTextBox5.Text, Convert.ToDecimal(bal), dateLabel.Text) != -1)

                                                        {
                                                            //display a message when an a record is added to the table
                                                            MessageBox.Show("Customer record updated successfully...");
                                                        }
                                                        else
                                                        {
                                                            //display message if data upload fails
                                                            MessageBox.Show("Database updation failed");
                                                        }


                                                    }
                                                    else
                                                    {
                                                        errorProvider1.SetError(fatherTextBox5, "Enter father name");
                                                    }
                                                }
                                                else
                                                {
                                                    errorProvider1.SetError(motherTextBox4, "Enter Mother name");
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
                                        errorProvider1.SetError(StateTextBox9, "State field cannot be empty");
                                    }
                                }
                                else
                                {
                                    errorProvider1.SetError(CitytextBox8, "City field cannot be empty");
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(addressTextBox7, "Address field cannot be empty");
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(PhoneTextBox6, "Phone number cannot be empty");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(nameTextBox, "Name cannot be empty");
                    }

                }
                else
                {
                    errorProvider1.SetError(accTextBox, "Account number must be greater than 100");
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }



           

        
    }
}
