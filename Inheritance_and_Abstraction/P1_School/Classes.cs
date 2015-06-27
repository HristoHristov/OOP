using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_School
{
    class Classes : Human
    {
        private string _textID;
        private List<Teacher> _teachers = new List<Teacher>();
        public Classes(string textID, List<Teacher> teacher)
            : base(null, textID)
        {
            this.TextID = textID;
            this.AddTeacher(teacher);
        }
        public string TextID
        { 
            get
            {
                return this._textID;
            }
            set
            {
                if(value.Length < 2 || string.IsNullOrEmpty(value))
                {
                    throw new FormatException("Text id should be more than 2 characters!");
                }
                this._textID = value;
            }
        }
        public void AddTeacher(List<Teacher> teachers)
        {
            if (teachers != null)
            {
                foreach (var teacher in teachers)
                {
                    this._teachers.Add(teacher);
                }
            }
        }
        public List<Teacher> GetTeacher()
        {
            return this._teachers;
        }
       
        
    }
}
