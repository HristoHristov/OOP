using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3GenericList
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            GenericList<string> genericList = new GenericList<string>();

            genericList.Add("4");
            genericList.Add("3");
            genericList.Add("6");
            genericList.Add("9");
            Console.WriteLine(String.Join(", ", genericList.element));
            genericList.InsertElement(1, "6");

            Console.WriteLine(genericList.Min("Pesho", "Gosho"));
        }
    }
}
