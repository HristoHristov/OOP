using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Company_Hierarchy
{
    class Person : IPerson
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        public Person(int id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public int ID
        {
            get { return this._id; }

            set
            {
                if(value < 100)
                {
                    throw new FormatException("The Id should be more than 0!");
                }
                this._id = value;
            }
        }
        public string FirstName
        {
            get { return this._firstName; }
            set
            {
                CheckString(value);
                this._firstName = value;
            }
        }
        public string LastName
        {
            get { return this._lastName; }
            set
            {
                CheckString(value);
                this._lastName = value;
            }
        }

        protected void CheckString(string inputData)
        {
            if(string.IsNullOrEmpty(inputData) || inputData.Length < 5 || inputData.Length > 50)
            {
                throw new FormatException("Invalid input data "+ inputData);
            }            
        }
    }
}
