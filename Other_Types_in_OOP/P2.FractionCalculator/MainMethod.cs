using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.FractionCalculator
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Fraction first = new Fraction(22, 7);
            Fraction second = new Fraction(40, 4);
            Fraction result = first + second;
            Console.WriteLine(result.Nominator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
        }
    }
}
