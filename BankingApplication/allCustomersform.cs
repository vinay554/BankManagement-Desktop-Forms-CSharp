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
    //this form displays the complete list of customers data from the table
    public partial class allCustomersform : Form
    {
        public allCustomersform()
        {
            InitializeComponent();
        }
        private static allCustomersform customersform;
        public static allCustomersform GetCustomersForm()
        {
            if (customersform == null) customersform = new allCustomersform();
            return customersform;
        }//GetCustomersForm()
        private void allCustomersform_FormClosing(object sender, FormClosingEventArgs e)
        {
            customersform = null;
        }//form closing

        private void allCustomersform_Load(object sender, EventArgs e)
        {
            //this form should display data once loaded
            BankIntermediary bankIntermediary = new BankIntermediary();
            try
            {
                //assign the table data to datagridview's data
                dataGridView1.DataSource = bankIntermediary.GetAllCustomers();
            }//end try
            catch (Exception ex)
            {
                throw ex;
            }//catch
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
