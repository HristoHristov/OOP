using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Bank_of_Kurtovo_Konare
{
    class IndividualCustomer : Customer
    {
        private string _lastName;
        public IndividualCustomer(string firstName, string lastName, string egn)
            : base(firstName, egn)
        { }
        public string LastName
        {
            get { return this._lastName; }
            set
            {
                CheckString(value);
                this._lastName = value;
            }
        }
    }
}
