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
    //this form displays the staff details using a function delegate instance
    public partial class StaffDetails : Form
    {
        //defining an enum
        public enum States
        {
            Kansas,
            Missouri
        }
        public StaffDetails()
        {
            InitializeComponent();
        }
        private static StaffDetails staffdetails;
        public static StaffDetails GetStaffDetails()
        {
            if (staffdetails == null) staffdetails = new StaffDetails();
            return staffdetails;
        }//GetStaffDetails()
        private void StaffDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            staffdetails = null;
        }//form closing
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getStaffbutton_Click(object sender, EventArgs e)
        {
            Func<string, string> toStringCaseDelegate = s => s.ToString() + Environment.NewLine+"Please contact them for any queries";
            string state = branchTextBox.Text;
            if(state =="Kansas" || state =="Missouri")
            {
                foreach(string i in Enum.GetNames(typeof(States)))
                {
                    if (state == "Kansas")
                    {
                        getStaffLabel.Text = toStringCaseDelegate("Manager: Samuel Smith" + Environment.NewLine + "Contact: (+1) 917-232-0567");

                    }
                    else if (state == "Missouri")
                    {
                        getStaffLabel.Text = toStringCaseDelegate("Manager: Michael Strokes" + Environment.NewLine + "Contact: (+1) 917-561-0245");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a state name");
            }
              
        }
    }
}
