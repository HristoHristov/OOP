namespace P2_Human_Student_and_Worker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Student : Human
    {
        private string _facultyNumber;
        private static List<Student> _studentsObj = new List<Student>();
        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
            this.AddStudent();
        }
        public string FacultyNumber 
        {
            get { return this._facultyNumber;  }
            set
            {
               if((string.IsNullOrEmpty(value)) || (value.Length < 5 || value.Length > 10))
               {
                   throw new FormatException("Invalid Facultuy Nunber" + value);
               }
               this._facultyNumber = value;
            }
        }
        public static List<Student> GetStudent
        {
            get { return Student._studentsObj; }
        }
        private void AddStudent()
        {
            Student._studentsObj.Add(this);
        }
        
        public static IEnumerable<Student> SortingStudent()
        {
            IEnumerable<Student> sorting = Student.GetStudent.OrderBy(facultyNum => facultyNum._facultyNumber);
            return sorting;
        }
    }
}
