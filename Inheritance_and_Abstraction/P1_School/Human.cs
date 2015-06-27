using System;
using System.Collections.Generic;
namespace P1_School
{
    abstract class Human
    {
        private string _name;
        private string _id;
       
        public Human(string name, string id, string details=null)        
        {
            this.Name = name;
            this.ID = id;
            this.Details = details;
        }

        public string Details { get; set; }
        public string Name
        {
            get { return this._name; }
            set
            {
                CheckData(value);
                this._name = value;
            }
        }
        public string ID
        {
            get { return this._id; }
            set
            {
                CheckData(value);
                this._id = value;
            }
        }
        protected void CheckData(string inputData)
        {
            if (inputData != null && inputData.Length < 3)
            {
                throw new FormatException("Invalid input data" + inputData);
            }
        }


       
    }
}
