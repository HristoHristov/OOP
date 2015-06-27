using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_StringBuilder_Extensions
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            var str = new StringBuilder("Functional Programming");
            Console.WriteLine(str.Substring(0, 11));

            str = new StringBuilder("Functional funcTional Programming");
            Console.WriteLine(str.RemoveText("Functional"));
            Console.WriteLine(str.AppendAll(new string[] { " ", "one", " ", "two" }));
        }
    }
}
