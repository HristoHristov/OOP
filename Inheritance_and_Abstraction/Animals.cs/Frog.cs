using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Animals
    {
        private static List<int> averageFrog = new List<int>();
        public Frog(string name, int age, string gender, string produceSound)
            :base(name, age, gender)
        {
            this.SetProduceSound = produceSound;
            Frog.averageFrog.Add(Age);
        }
        public override void ProduceSound()
        {
            Console.WriteLine(this._produceSound);
        }
        public static List<int> AverageFrog()
        {
            return Frog.averageFrog;
        }
    }
}
