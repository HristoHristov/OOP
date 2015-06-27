using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Bank_of_Kurtovo_Konare
{
    class LoanAccounts : Account
    {
        private Type _customerType;
        private double _calculateInterestRate;
        public LoanAccounts(Customer customer, double balance, double interestRate, DateTime creationDate)
            : base(customer, balance, interestRate, creationDate)
        {
            this._customerType = customer.GetType();
            this.CalculateInterest();
        }
        public override void CalculateInterest()
        {
            if (typeof(IndividualCustomer) == this._customerType)
            {
                if (this.GetMonth() > 3)
                {
                    this._calculateInterestRate = this.CalculateInterestRateFormula();
                }
                else
                {
                    this._calculateInterestRate = 0;
                }
            }
            else if (typeof(Entity) == this._customerType)
            {
                if (this.GetMonth() > 2)
                {
                    this._calculateInterestRate = this.CalculateInterestRateFormula();
                }
                else
                {
                    this._calculateInterestRate = 0;
                }
            }
        }
    }
}
