using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Company_Hierarchy.Classes
{
    class Employee : Person
    {
        private double _salary;
        private string _department;
        public Employee(int id, string firstName, string lastName, double salary, string department)
            : base(id, firstName, lastName)
        {
            this.Department = department;
            this.Salary = salary;
        }
        public double Salary
        {
            get { return this._salary; }
 
            set
            {
                if(value < 0)
                {
                    throw new FormatException("The salary can not be less than 0;");
                }
                this._salary = value;
            }
        }
        public string Department 
        {
            get { return this._department; }
            set
            {
                CheckString(value);
                this._department = value;
            }
        }

    }
}
