using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P1Customer.Classes
{
    class Payment
    {
        private string _productName;
        private decimal _price;
        private bool isEquals = true;
        private const decimal _invalidPrice = 0.0m;

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }
        private string ProductName
        {
            get
            {
                return this._productName;
            }
            set
            {
                CheckingData.CheckingString(value, 5, 40, "Invalid Name " + value);
                this._productName = value;
            }
        }
        private decimal Price
        {
            get
            {
                return this._price;
            }
            set
            {
                if(value <= _invalidPrice)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be less than 0");
                }
                this._price = value;
            }
        }
        public override bool Equals(object obj)
        {
            Payment payment = obj as Payment;
            if(payment == null)
            {
                isEquals = false;
            }
            CheckingData.IsEquals(this._productName, payment._productName, ref this.isEquals);
            if (Object.Equals(this._price, payment._price))
            {
                this.isEquals = false;
            }
            return this.isEquals;
        }
        public static bool operator ==(Payment paym1, Payment paym2)
        {
            return Payment.Equals(paym1, paym2);
        }
        public static bool operator !=(Payment paym1, Payment paym2)
        {
            return !(Payment.Equals(paym1, paym2));
        }
        public override int GetHashCode()
        {
            return this._productName.GetHashCode() ^ this._price.GetHashCode();
        }
        public override string ToString()
        {
            return String.Format("Product Name: {0} \t\t - \t\t Price: {1}", ProductName, Price);
        }
    }
}
