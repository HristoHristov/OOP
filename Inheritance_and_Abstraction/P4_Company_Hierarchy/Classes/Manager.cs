using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4_Company_Hierarchy.Classes;
namespace P4_Company_Hierarchy
{
    class Manager : Person, IManager
    {
        private List<Employee> _employeesUnderHisComand = new List<Employee>();
        private double _salary;
        public Manager(int id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName)
        {
            
            this.Salary = salary;
        }

        public void AddEmployeeUnderHisComand(List<Employee> employees)
        {
            foreach(var employee in employees)
            {
                this._employeesUnderHisComand.Add(employee);                
            }
        }
        public double Salary
        {
            get { return this._salary; }
            set
            {
                if(value < 0)
                {
                    throw new FormatException("Salary can not be less than 0;");
                }
                this._salary = value;
            }
        }
        public override string ToString()
        {
            string result = String.Format("\t\t\t\tManager: \nFirst Name: {0};  Last Name {1} Salary: {2}\n\t\t\t\tEmployee:", this.FirstName, this.LastName, this.Salary);
            
            foreach(var employee in this._employeesUnderHisComand)
            {
                result += String.Format("\nFirst Name {0};  Last Name {1};  Salary {2}", employee.FirstName, employee.LastName, employee.Salary);
            }
            return result;
        }
    }
}
