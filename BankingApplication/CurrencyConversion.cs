using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    internal class CurrencyConversion : Calculator
    {
        //defining an override method for currency conversion
        public override string CalculateAmount(int amount, double rate)
        {
            double calculatedAmount = amount * rate;
            string message = "The equivalent value is :" + Convert.ToString(calculatedAmount);
            return message;
        }
    }
}
