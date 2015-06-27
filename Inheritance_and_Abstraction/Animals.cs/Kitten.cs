using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Cat
    {
        private static List<int> averageFemaleCat = new List<int>();
        public Kitten(string name, int age, string gender, string produceSound)
            : base(name, age, gender, produceSound)
        {
            this.SetProduceSound = produceSound;
            Kitten.averageFemaleCat.Add(Age);
        }
        public override void ProduceSound()
        {
            Console.WriteLine(this._produceSound);
        }
        public static List<int> AverageFemaleCat()
        {
            return Kitten.averageFemaleCat;
        }
    }
}
