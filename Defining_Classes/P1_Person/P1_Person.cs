namespace P1_Person
{
    using System;
    class P1_Pesron
    {
        public static void Main()
        {
            Person Ivan = new Person("Ivan Ivanov", 25, "AtanasK@abv.bg");
            Console.WriteLine(Ivan.ToString());
        }
    }
}
