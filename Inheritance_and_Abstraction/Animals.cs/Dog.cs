using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{   
    class Dog : Animals
    {
        private static List<int> averageD = new List<int>();
        public Dog(string name, int age, string gender, string produceSound)
            :base(name, age, gender)
        {
            this.SetProduceSound = produceSound;
            Dog.averageD.Add(Age);
        }
        public override void ProduceSound()
        {
            Console.WriteLine(this._produceSound);
        }
        public static List<int> AverageDog()
        {
            return Dog.averageD;
        }
       
    }
}
