using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animals : ISound
    {
        private string _name;
        private int _age;
        private string _gender;
        protected string _produceSound;
       
        public Animals(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get { return this._name; }
            set
            {
                CheckData(value);
                this._name = value;
            }
        }
        public int Age
        {
            get { return this._age; }
            set
            {
                if(value <= 0 || value > 130 )
                {
                    throw new FormatException("Invalid Age format");
                }
                this._age = value;
            }
        }
        public string Gender
        {
            get { return this._gender; }
            set
            {
                if(value != "male" && value != "female")
                {
                    throw new FormatException("The gender should be male or female!");
                }
                this._gender = value;
            }
        }
        protected string SetProduceSound
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    CheckData(value);
                    this._produceSound = value;
                }
                else
                {
                    this._produceSound = " - ";
                }
            }
        }

        protected void CheckData(string inputData)
        {           
            if(inputData.Length < 5 || inputData.Length > 50)
            {
                throw new FormatException("The input data shoukd be 5..50 characters!" + inputData);
            }           
        }
        public abstract void ProduceSound();       
    }
}
