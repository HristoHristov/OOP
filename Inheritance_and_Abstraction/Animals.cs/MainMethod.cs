using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Dog pinchi = new Dog("Pinchi", 2, "male", "bauuuuuuuu");
            Dog suzi = new Dog("Pinchi", 4, "male", "bauuuuuuuu");
            Dog djeimi = new Dog("Pinchi", 4, "male", "bauuuuuuuu");

            Kitten mimi = new Kitten("kitten", 5, "female", "miiiauuu");
            Kitten kuki = new Kitten("kitten", 5, "female", "miiiauuu");

            Tomcat tom = new Tomcat("Top4o", 15, "male", "myuuuu");

            Frog crazy = new Frog("Crazy Frog", 10, "male", "Kvaaa");
            Console.WriteLine(Frog.AverageFrog().Count());
        }
    }
}
