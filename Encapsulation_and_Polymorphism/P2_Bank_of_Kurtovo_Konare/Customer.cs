using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Bank_of_Kurtovo_Konare
{
    class Customer
    {
        private string _name;
        private string _egnOrUic;
        public Customer(string name, string egnOrUIC)
        {
            this.Name = name;
            this.EgnOrUIC = egnOrUIC;
        }

        public string Name
        {
            get { return this._name; }
            set
            {
                CheckString(value);
                this._name = value;
            }
        }
        public string EgnOrUIC
        {
            get { return this._egnOrUic; }
            set
            {
                if (value.Length > 10 || value.Length < 10)
                {
                    throw new FormatException("Invalid EGN " + value);
                }
                this._egnOrUic = value;
            }
        }
        protected void CheckString(string data)
        {
            if (string.IsNullOrEmpty(data) || data.Length < 2 || data.Length > 50)
            {
                throw new FormatException("Input data should be more than 2 characters! " + data);
            }
        }
    }
}
