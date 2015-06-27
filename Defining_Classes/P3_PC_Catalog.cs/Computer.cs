using System;

namespace P3_PC_Catalog
{
    class Computer
    {
        private string computerName;
        private Component processor;
        private Component graphicCard;
        private Component motherboard;
        private Component ram;
        private Component hdd;
        private Component battery;
        private decimal totalPrice;
        private Component[] arr = new Component[6];

        public Computer(string computerName, Component processor, Component graphicCard,
                        Component motherboard, Component ram, Component hdd, Component battery)
        {
            this.computerName = computerName;
            this.processor = processor;
            this.graphicCard = graphicCard;
            this.motherboard = motherboard;
            this.ram = ram;
            this.hdd = hdd;
            this.battery = battery;
            arr[0] = processor; arr[1] = graphicCard; arr[2] = motherboard;
            arr[3] = ram; arr[4] = hdd; arr[5] = battery;
            TotalPrice(arr);

        }
        public Computer(string computerName, Component processor, Component graphicCard,
                        Component motherboard, Component ram, Component hdd)
            : this(computerName, processor, graphicCard, motherboard, ram, hdd, null)
        { }
        public Computer(string computerName, Component processor, Component graphicCard,
                        Component motherboard, Component ram)
            : this(computerName, processor, graphicCard, motherboard, ram, null, null)
        { }
        public Computer(string computerName, Component processor, Component graphicCard,
                        Component motherboard)
            : this(computerName, processor, graphicCard, motherboard, null, null, null)
        { }

        public void CheckString(string data)
        {
            if (data.Length < 3 || data.Length > 50)
            {
                throw new ArgumentOutOfRangeException("The Laptop shoul be from 3 to 50 characters!");
            }
        }

        public void TotalPrice(Component[] arr)
        {
            decimal sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    sum += arr[i].ComponentPrice;
                }
            }
            this.totalPrice = sum;//.ToString("#,#.00# lv."); ;
        }
        public string ComputerName
        {
            set
            {
                CheckString(value);
                this.computerName = value;
            }
        }
        public decimal Price
        {
            get { return this.totalPrice; }
        }
        public void PrintPCCatalog()
        {
            Console.WriteLine("\n---------------------------------------------------------\n");
            Console.WriteLine("\t" + this.computerName);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    Console.WriteLine(arr[i].ToString());
                }
            }
            Console.WriteLine("\nTotal Price: {0} lv.", this.totalPrice);
        }
    }
}
