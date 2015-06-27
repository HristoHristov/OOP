using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_School
{
    class Students : Classes
    {      
        private string _name;
        private int _classNum;
        public Students(string name, int numInClass, string classID)
            : base(classID, null)
        {
            this.Name = name;
            this.NumInClass = numInClass;
          
        }
        
        public string Name
        {
            get { return this._name; }
            set
            {
                if(value.Length < 3 )
                {
                    throw new FormatException("Name should be than 3 characters");
                }
                this._name = value;
            }
        }
        public int NumInClass
        {
            get { return this._classNum; }
            set
            {
                if (value < 1)
                {
                    throw new FormatException("Value should be more than 0!");
                }
                this._classNum = value;
            }
        }
        
    }
}
