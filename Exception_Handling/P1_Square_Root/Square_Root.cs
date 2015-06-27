using System;

namespace P1_Square_Root
{
    static class Square_Root
    {
        private static double sqrt;
        public static void CheckData(double sqrt)
        {
            if (sqrt.GetType() != typeof (double))
            {
                throw new FormatException();
            }
        }

        public static void CalculateSqrt()
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                Square_Root.CheckData(number);
                Square_Root.sqrt = Math.Sqrt(number);

                Console.WriteLine(Square_Root.sqrt);
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
