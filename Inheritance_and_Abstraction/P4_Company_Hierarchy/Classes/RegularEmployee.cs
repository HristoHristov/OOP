using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Company_Hierarchy.Classes
{
    class RegularEmployee : Employee 
    {
        public RegularEmployee(int id, string firstName, string lastName, double salary, string department)
            : base(id, firstName, lastName, salary, department)
        {}
    }
}
