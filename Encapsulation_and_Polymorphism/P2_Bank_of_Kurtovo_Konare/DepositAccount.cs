using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Bank_of_Kurtovo_Konare
{
    class DepositAccount : Account
    {


        private double _calculateInterestRate;
        public DepositAccount(Customer customer, double balance, double interestRate, DateTime creationDate)
            : base(customer, balance, interestRate, creationDate)
        {
            this.CalculateInterest();
        }
        public override void CalculateInterest()
        {
            if (this.Balance < 1000)
            {
                this._calculateInterestRate = 0;

            }
            else
            {
                this._calculateInterestRate = this.CalculateInterestRateFormula();
            }

        }
    }

}
