using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P2_Laptop_Shop
{
    using System;
    class Laptop
    {
        private string model;
        private string manufacturer;
        private double price;
        private Battery elements = new Battery();
        public Laptop(string model, string manufacturer, Battery elements, double price)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.SetElements(elements);
        }
        public Laptop(string model, double price)
            : this(model, null, null, price)
        { }
        public Laptop(string model, string manfacturer, double price)
            : this(model, manfacturer, null, price)
        { }
        public Laptop(string model, Battery elem, double price)
            : this(model, null, elem, price)
        { }

        public string CheckStringData(string data)
        {
            if (data != null)
            {
                if ((data.Length < 2 || data.Length > 50))
                {
                    throw new ArgumentOutOfRangeException("Laptop element: '" + data + "' should be from 2 to 50 characters!");
                }
                return data;
            }
            else
            {
                return data = " - ";
            }
        }
        public void CheckDoubleData(double data)
        {
            if (data < 0)
            {
                throw new ArgumentOutOfRangeException("Laptop element: '" + data + "' should be positive");
            }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                this.model = this.CheckStringData(value);
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                this.manufacturer = this.CheckStringData(value); ;
            }
        }
        public double Price
        {
            get { return this.price; }
            set
            {
                CheckDoubleData(value);
                this.price = value;
            }
        }

        public Battery BatteryChangeElements()
        {
            return this.elements;
        }
        public void SetElements(Battery elements)
        {
            if (elements != null)
            {
                if (elements.GetType() != this.elements.GetType())
                {
                    throw new Exception("The format of element should be Battery!");
                }
                this.elements = elements;
            }

        }
        public override string ToString()
        {
            return string.Format("\tLaptop\nModel: {0} \nManufacturer: {1} \n\tElement: \n{2} \nPrice: {3} lv.",
                                    this.model, this.manufacturer, this.elements.ToString(), this.price);
        }
    }
}
