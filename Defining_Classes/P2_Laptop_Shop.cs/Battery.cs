using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P2_Laptop_Shop
{
    class Battery
    {
        private string processor;
        private int ram;
        private string graphicCard;
        private string hdd;
        private string screen;
        private string battery;
        private double batteryLife;

        public Battery(string processor = null, int ram = 0, string graphicCard = null, string hdd = null, string screen = null, string battery = null, double batteryLife = 0)
        {
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicCard = graphicCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.BatteryType = battery;
            this.BatteryLife = batteryLife;
        }

        public string CheckStringData(string data)
        {
            if (data != null)
            {
                if ((data.Length < 2 || data.Length > 50))
                {
                    throw new ArgumentOutOfRangeException("Laptop element: '" + data + "' should be from 2 to 50 characters!");
                }
                return data;
            }
            else
            {
                return data = " - ";
            }
        }
        public void CheckIntegerData(int data)
        {
            if (data < 0)
            {
                throw new ArgumentOutOfRangeException("Laptop element: '" + data + "' should be positive");
            }

        }
        public void CheckDoubleData(double data)
        {
            if (data < 0)
            {
                throw new ArgumentOutOfRangeException("Laptop element: '" + data + "' should be positive");
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                this.processor = this.CheckStringData(value); ;
            }
        }
        public int RAM
        {
            get { return this.ram; }
            set
            {
                this.CheckIntegerData(value);
                this.ram = value;
            }
        }
        public string GraphicCard
        {
            get { return this.graphicCard; }
            set
            {
                this.graphicCard = this.CheckStringData(value); ;
            }
        }
        public string HDD
        {
            get { return this.hdd; }
            set
            {
                this.hdd = this.CheckStringData(value);
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                this.screen = this.CheckStringData(value);
            }
        }
        public string BatteryType
        {
            get { return this.battery; }
            set
            {
                this.battery = this.CheckStringData(value);
            }
        }
        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                this.CheckDoubleData(value);
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            return string.Format("\nProcessor: {0} \nRAM: {1} GB \nGraphic Card: {2} \nHDD: {3} \nScreen: {4} \nBattery: {5} \nBattery Life: {6} hours",
                                this.processor, this.ram, this.graphicCard, this.hdd, this.screen, this.battery, this.batteryLife);
        }
    }
}
