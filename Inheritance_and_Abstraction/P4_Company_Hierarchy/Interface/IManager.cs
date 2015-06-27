namespace P4_Company_Hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using P4_Company_Hierarchy.Classes;
    interface IManager
    {
        void AddEmployeeUnderHisComand(List<Employee> employees);
        double Salary
        {
            set;
            get;
        }
    }
}
