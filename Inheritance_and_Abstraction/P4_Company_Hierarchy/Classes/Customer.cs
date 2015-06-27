using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Company_Hierarchy.Classes
{
    class Customer : Person
    {
        private double _totalAmount=0;
        private List<Purchases> _purchases = new List<Purchases>();

        public Customer(int id, string firstName, string lastName)
            : base(id, firstName, lastName)
        {}
        public double GetTotalAmount
        {
            get { return this._totalAmount; }
        }
        public void AddPurchase(Purchases purchase)
        {
            this._purchases.Add(purchase);
            this._totalAmount += purchase.Price;
        }
        public override string ToString()
        {
            string result = String.Format("Customer First Name: {0}; Last Name: {1}; Customer ID: {2} \n", this.FirstName, this.LastName, this.ID);
            foreach(var purchase in this._purchases)
            {
                result += String.Format("Purchase name: {0}; Date: {1}; price: {2}\n",purchase.Name, purchase.GetDate, purchase.Price);   
            }
            return result;
        }
    }
}
