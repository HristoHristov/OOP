using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4_Company_Hierarchy.Classes;
namespace P4_Company_Hierarchy.Interface
{
    interface ISalesEmployee
    {
        void AddSales(Purchases sale);
        List<Purchases> GetSales();
    }
}
