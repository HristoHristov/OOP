using System;
using System.Collections.Generic;
namespace P1_School    
{
    class Disciplines
    {
        private string _name;
        private int _numberOfLectures;
        private List<Students> _students = new List<Students>();
        public Disciplines(string name, int numberOfLectures, List<Students> students, string details=null)
        {
            this.NumberOfLectures = numberOfLectures;
            this.Name = name;
            this.AddStudents(students);
            
        }
        public string  Details{ get; set; }
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || value.Length < 3 )
                {
                    throw new FormatException("Invalid inputData " + value);
                }
                this._name = value;
            }
        }
        public int NumberOfLectures
        {
            get { return this._numberOfLectures; }
            set
            {
                if( value < 1 )
                {
                    throw new FormatException("The Number of lectures should be more than 0!");
                }
                this._numberOfLectures = value;
            }
        }
        public void AddStudents(List<Students> students)
        {
            foreach(var student in  students)
            {
                this._students.Add(student);
            }
        }
        public List<Students> GetStudents()
        {
             return this._students; 
        }
        
    }
}
