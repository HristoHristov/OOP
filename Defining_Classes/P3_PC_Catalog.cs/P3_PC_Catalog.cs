namespace P3_PC_Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class P3_PC_Catalog
    {
        static void Main(string[] args)
        {
            Computer DELL = new Computer("Dell Inspiron 3531", new Component("Processor", "Intel Celeron N2830", 538.80m), new Component("Graphic Card", "Intel HD Graphics", 76.00m), new Component("Motherboard", "GIGABYTE X99", 300.00m),
                                        new Component("RAM", "DDR3 8 GB 200 MHZ", 100.00m), new Component("HDD", "Seagate 1TB 32MB 7200rpm SATA3 ST1000DM003", 343.00m), new Component("Battery", "VAIO VPC-E Series VGP-BPS22", 123.22m));
            Computer Lenovo = new Computer("Lenovo B540", new Component("Processor", "Intel Celeron N2830", 238.80m), new Component("Graphic Card", "Intel HD Graphics", 46.00m), new Component("Motherboard", "GIGABYTE X99", 200.00m),
                                        new Component("RAM", "DDR3 8 GB 200 MHZ", 100.00m), new Component("HDD", "Seagate 1TB 32MB 7200rpm SATA3 ST1000DM003", 343.00m));
            Computer HP = new Computer("HP 250 G3", new Component("Processor", "Intel Celeron N2830", 238.80m), new Component("Graphic Card", "Intel HD Graphics", 46.00m), new Component("Motherboard", "GIGABYTE X99", 200.00m),
                                        new Component("RAM", "DDR3 8 GB 200 MHZ", 100.00m), new Component("HDD", "Seagate 1TB 32MB 7200rpm SATA3 ST1000DM003", 843.00m));
            Computer SONY = new Computer("SONY", new Component("Processor", "Intel Celeron N2830", 100m), new Component("Graphic Card", "Intel HD Graphics", 100m), new Component("Motherboard", "GIGABYTE X99", 100.00m),
                                        new Component("RAM", "DDR3 8 GB 200 MHZ", 100.00m), new Component("HDD", "Seagate 1TB 32MB 7200rpm SATA3 ST1000DM003", 100m));

            Computer[] PC = { DELL, Lenovo, HP, SONY };
            IEnumerable<Computer> sorting = PC.OrderBy(pcCatalog => pcCatalog.Price);
            foreach (Computer pc in sorting)
            {
                pc.PrintPCCatalog();
            }
        }
    }
}
