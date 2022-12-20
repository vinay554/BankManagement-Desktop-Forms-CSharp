using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class Calculator
    {
        //defining a virtual method which will be overriden in base class
        public virtual string CalculateAmount(int amount, double rate)
        {
            return $"This is a virtual method";
        }//CalculateAmount()
    }
}
