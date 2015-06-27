using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Bank_of_Kurtovo_Konare
{
    abstract class Account : ICalcInterest
    {
        private Customer _customer;
        private double _balance = 0;
        private double _interestRate;
        private double _months;
        private double _calculateInterestRate;
        public Account(Customer customer, double balance, double interestRate, DateTime creationDate)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.SetMonth(creationDate);
            this._customer = customer;
        }
        public double Balance
        {
            get { return this._balance; }

            set
            {
                CheckingNumber(value);
                this._balance += value;
            }
        }
        public Customer GetCustomer
        {
            get
            {
                return this._customer;
            }
        }
        public double InterestRate
        {
            get { return this._interestRate; }

            set
            {
                CheckingNumber(value);
                this._interestRate += value;
            }

        }
        public double GetInterest
        {
            get { return this._calculateInterestRate; }
        }
        private void SetMonth(DateTime creationDate)
        {

            this._months = ((DateTime.Now.Year - creationDate.Year) * 12) + (DateTime.Now.Month - creationDate.Month);
        }
        public double GetMonth()
        {
            return this._months;
        }
        protected void CheckingNumber(double num)
        {
            if (num < 0)
            {
                throw new FormatException("The input date can not be negative number!" + num);
            }
        }

        protected double CalculateInterestRateFormula()
        {
            this._calculateInterestRate = this.Balance * (1 + this._interestRate * this.GetMonth());
            return this._calculateInterestRate;
        }
        public abstract void CalculateInterest();

    }
}
