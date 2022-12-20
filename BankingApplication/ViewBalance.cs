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
    public partial class ViewBalance : Form
    {
        //This form allows the user to view his balance after entering his account no
        public ViewBalance()
        {
            InitializeComponent();
            loaddate();
        }
        BankDataClass bankData = new BankDataClass();

        private static ViewBalance viewBalance;
        private void loaddate()
        {
            dateLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }//loaddate()
        public static ViewBalance GetViewBalance()
        {
            //to make the form a singleton form
            if (viewBalance == null) viewBalance = new ViewBalance();
            return viewBalance;
        }//GetViewBalance()

        private void ViewBalance_FormClosing(object sender, FormClosingEventArgs e)
        {
            //makes the instance as null after closing the form
            viewBalance = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaring variable to hold the input data
            string no = accTextBox.Text;
            string query = "SELECT * FROM UserAcc WHERE Account_No =" + no;
            var reader = bankData.GetReader(query, CommandType.Text);

            if (reader.Read())
            {
                nameTextBox.Text = reader["Name"].ToString();

                resultTextBox.Text = reader["Balance"].ToString();

            }//end if
            else
            {
                MessageBox.Show("No record found for the given Account Number");
            }//end else
            reader.Close();
        }//button1_Click()
    }
}
