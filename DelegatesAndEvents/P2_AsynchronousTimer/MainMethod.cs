using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AsynchronousTimer
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Action<int> firstTest = (num) => Console.WriteLine("I am the first test.Timer:{0}", num);
            Action<int> secondTest = (num) => Console.WriteLine("I am the second test.Timer:{0}", num);

            
            var firstTimer = new AsyncTimer(firstTest, 10, 500);
            var secondTimer = new AsyncTimer(secondTest, 5, 1000);

            
            firstTimer.Run();
            secondTimer.Run();
        }
    }
}
