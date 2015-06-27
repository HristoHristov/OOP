using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat : Cat
    {
        private static List<int> averageMaleCat = new List<int>();
        public Tomcat(string name, int age, string gender, string produceSound)
            : base(name, age, gender,produceSound)
        {
            this.SetProduceSound = produceSound;
            Tomcat.averageMaleCat.Add(Age);
        }
        public override void ProduceSound()
        {
            Console.WriteLine(this._produceSound);
        }
        public static List<int> AverageMaleCat()
        {
            return Tomcat.averageMaleCat;
        }
    }
}
