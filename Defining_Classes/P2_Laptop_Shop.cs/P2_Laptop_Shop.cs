namespace P2_Laptop_Shop
{
    using System;
    class P2_Laptop_Shop
    {
        static void Main()
        {
            Laptop Lenovo = new Laptop("Lenovo", "ZMLKSK", new Battery("AMD XS567", 16, "NVIDIA G564 M", "Seagate Momentus 320GB", "LG MMZD", "Lenovo MNZNSJS", 4.43), 800);
            Console.WriteLine(Lenovo.ToString());

        }
    }
}
