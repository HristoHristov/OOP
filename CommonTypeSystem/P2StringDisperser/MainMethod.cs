using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2StringDisperser
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            StringDisperser disp = new StringDisperser("Moini mi", "oinimi", "Penke le");
            StringDisperser disp2 = new StringDisperser("Moini mi", "oinimi", "Penke le");
            Console.WriteLine("disp.Equals(disp2) - {0}",disp.Equals(disp2));
            Console.WriteLine("disp == disp2 - {0}", disp == disp2);
            Console.WriteLine("disp != disp2 - {0}", disp != disp2);

            StringDisperser disp3 = (StringDisperser)disp2.Clone();
            disp3.SetParameter("Mini", "Maxi");
            Console.WriteLine("\t\t\t Disp2 \n" + disp2);
            Console.WriteLine("\t\t\t Disp3 \n" + disp3);
        }
    }
}
