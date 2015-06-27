using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_InterestCalculator
{
    class CalculateInterestProblem1
    {
        private static string type;
        public delegate void CalculateInterest(decimal sumMoney, decimal interest, int years);
        public static void GetSimpleInterest(decimal sumMoney, decimal interest, int years)
        {
            decimal A = sumMoney * (1 + (interest / 100) * years);
            CalculateInterestProblem1.type = "simple";
            Console.WriteLine("Type: {0} A = {1:0.0000}", CalculateInterestProblem1.type, A);
        }
        public static void GetCompoundInterest(decimal sumMoney, decimal interest, int years)
        {
            int n = 12;
            decimal A = ((1 + (interest / 100) / n));
            double result = Math.Pow(Convert.ToDouble(A), 120);
            result *= (double)sumMoney;
            // A = Math.Pow(Convert.ToDouble(A), 5);
            CalculateInterestProblem1.type = "compound";
            Console.WriteLine("Type: {0} A = {1:0.0000}", CalculateInterestProblem1.type, result);
        }
        static void Main(string[] args)
        {
            CalculateInterest interest = new CalculateInterest(GetSimpleInterest);

            interest(2500m, 7.2m, 15);
            interest = GetCompoundInterest;
            interest(500m, 5.6m, 10);
        }
    }
}
