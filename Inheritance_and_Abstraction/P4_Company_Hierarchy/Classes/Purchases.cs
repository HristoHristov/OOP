using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Company_Hierarchy.Classes
{
    class Purchases
    {
        private string _name;
        private DateTime _date;
        private double _price;
        public Purchases(string name, DateTime date, double price)
        {
            this.Name = name;
            this._date = date;
            this.Price = price;
        }
        public string Name
        {
            get { return this._name; }
            set
            {
                if(string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new FormatException("The name should be more than 5");
                }
                this._name = value;
            }
        }
        public double Price
        {
            get{return this._price;}
            set
            {
                if(value < 0)
                {
                    throw new FormatException("The price can not be less than 0!");
                }
                this._price = value;
            }
        }
        public DateTime GetDate {
            get { return this._date; }
        }
    }
}
