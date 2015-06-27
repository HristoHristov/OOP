using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4_Company_Hierarchy.Interface;

namespace P4_Company_Hierarchy.Classes
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Purchases> _sales = new List<Purchases>();
        public SalesEmployee(int id, string firstName, string lastName, double salary, string department)
            : base(id, firstName, lastName, salary, department)
        {

        }

        public void AddSales(Purchases sale)
        {
            this._sales.Add(sale);
        }
        public List<Purchases> GetSales()
        {
            return this._sales;
        }
        public override string ToString()
        {
            string result = String.Format("\t\t\t\tSales Employee: \nFirst Name: {0};  Last Name: {1}  Salary {2};\n\t\t\t\tSales: ", this.FirstName, this.LastName, this.Salary);
            foreach(var sale in this._sales)
            {
                result += String.Format("\n Name: {0};  Date: {1};  Price: {2}\n", sale.Name, sale.GetDate, sale.Price);
            }
            return result;
        }

    }
}
