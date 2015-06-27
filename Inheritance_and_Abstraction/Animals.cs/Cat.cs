using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animals
    {
        public Cat(string name, int age, string gender, string produceSound)
            : base(name, age, gender)
        {
            this.SetProduceSound = produceSound;
        }
        public override void ProduceSound()
        {
            Console.WriteLine(this._produceSound);
        }
    }
}
