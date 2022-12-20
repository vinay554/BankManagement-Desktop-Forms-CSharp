using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class CurrentAccount : IBank
    {
        string typeOfAccount;
        double interest_value;
        public CurrentAccount(string accountType, double interestRate)
        {
            typeOfAccount = accountType;
            interest_value = interestRate;
        }
        public double interest
        {
            get { return interest_value; }
            set { interest_value = value; }
        }
        public string showDetails(IBank objectName)
        {
            return $"This class is derived from{objectName.GetType().BaseType}" + Environment.NewLine;
        }
    }
}
