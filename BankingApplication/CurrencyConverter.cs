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
    //this functionality converts currency from $ to specified country's currency
    public partial class CurrencyConverter : Form
    {

        string convertFromCurrency, convertToCurrency;
        double currencyFrom, currencyTo;
        public CurrencyConverter()
        {
            InitializeComponent();
        }
        private static CurrencyConverter currencyconverter;
        public static CurrencyConverter GetCurrencyConverter()
        {
            //making the from singleton
            if (currencyconverter == null) currencyconverter = new CurrencyConverter();
            return currencyconverter;
        }//GetCurrencyConverter()

        private void CurrencyConverter_FormClosing(object sender, FormClosingEventArgs e)
        {
            currencyconverter = null;
        }//form closing

        private void submitButton_Click(object sender, EventArgs e)
        {
            ConvertCurrency();
        }//submitButton_Click()

        public void ConvertCurrency()
        {
            //declare a variable to hold the amount entered
            string value;
            value = valueTextBox.Text;
            int amount = Convert.ToInt32(value);
            convertToCurrency = comboBox2.Text;
            //convert the amount based on selected value from combobox
            if(string.Equals(convertToCurrency, "INR"))
            {
                CurrencyConversion currencyConversion = new CurrencyConversion();
                string message;
                message = currencyConversion.CalculateAmount(amount, 81.67);
                MessageBox.Show(message+"INR");
            }
            if (string.Equals(convertToCurrency, "JPY"))
            {
                CurrencyConversion currencyConversion = new CurrencyConversion();
                string message;
                message = currencyConversion.CalculateAmount(amount, 139.12);
                MessageBox.Show(message+"JPY");
               
            }
            if (string.Equals(convertToCurrency, "EUR"))
            {
                CurrencyConversion currencyConversion = new CurrencyConversion();
                string message;
                message = currencyConversion.CalculateAmount(amount, 0.96);
                MessageBox.Show(message+"EUR");
                
            }
            if (string.Equals(convertToCurrency, "GBP"))
            {
                CurrencyConversion currencyConversion = new CurrencyConversion();
                string message;
                message = currencyConversion.CalculateAmount(amount, 0.83);
                MessageBox.Show(message+"GBP");
                
            }
            if (string.Equals(convertToCurrency, "CAD"))
            {
                CurrencyConversion currencyConversion = new CurrencyConversion();
                string message;
                message = currencyConversion.CalculateAmount(amount, 1.34);
                MessageBox.Show(message+"CAD");
                
            }
            if (string.Equals(convertToCurrency, "AUD"))
            {
                CurrencyConversion currencyConversion = new CurrencyConversion();
                string message;
                message = currencyConversion.CalculateAmount(amount, 1.48);
                MessageBox.Show(message+"AUD");
                
            }

        }//ConvertCurrency()
    }
}
