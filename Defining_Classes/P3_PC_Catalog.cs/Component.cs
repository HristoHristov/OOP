namespace P3_PC_Catalog
{
    using System;
    class Component
    {
        private string componentName;
        private string details;
        private decimal price;

        public Component(string name, string details, decimal price)
        {
            this.ComponentName = name;
            this.Details = details;
            this.ComponentPrice = price;
        }
        public Component(string name, decimal price)
            : this(name, null, price)
        { }
        public void CheckingString(string data)
        {
            if (data.Length < 3 || data.Length > 50)
            {
                throw new ArgumentOutOfRangeException("The Component information shoul be from 3 to 50 characters!");
            }
        }
        public decimal CheckingPrice(decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("The price should be positive number!");
            }
            return this.price = price;
        }

        public string ComponentName
        {
            get { return this.componentName; }

            set
            {
                this.CheckingString(value);
                this.componentName = value;
            }
        }
        public string Details
        {
            get { return this.details; }

            set
            {
                if (value != null)
                {
                    this.CheckingString(value);
                    this.details = value;
                }
                else
                {
                    this.details = " - ";
                }
            }
        }
        public decimal ComponentPrice
        {
            get { return this.price; }

            set
            {
                this.price = CheckingPrice(value); ;
            }
        }
        public override string ToString()
        {
            return string.Format("\n \t{0} \n Details: {1}  \n Price: {2} lv.", this.componentName, this.details, this.price);
        }
    }
}
