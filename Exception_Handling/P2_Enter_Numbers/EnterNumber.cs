using System.Collections.Generic;

namespace P2_Enter_Numbers
{
    using System;
    static class EnterNumber
    {
        public static void ReadNumber(int start, int end)
        {
            int index = start;
            double min = double.MinValue;
            string result="";

            while (index < end)
            {
                try
                {
                    double inputNumber = double.Parse(Console.ReadLine());

                    if (inputNumber > min)
                    {
                        index++;
                        result += inputNumber + " ";
                        min = inputNumber;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Please enter number more than " + min);
                }
            }
            Console.WriteLine(result);
        }
    }
}
