using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CustomLINQExtensionMethods
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Func<string, bool> predicate = a =>
                {
                    return (bool)!a.Contains("C# OOP");
                };

            List<string> str = new List<string>(){"C# OOP", "No name", "Laravel is OOP", "PHP OOP is cool", "C# OOP is Cool"};
            IEnumerable<string> asd = str;
            IEnumerable<string> strinos = Enumerable.Empty<string>();
            strinos = new string[] { "cool", "OOP" };
            var rsult = asd.WhereEndsWith<string>(strinos);
            foreach (var ress in rsult)            
            {
                Console.WriteLine(ress);
            }
        }
        
    }
}
