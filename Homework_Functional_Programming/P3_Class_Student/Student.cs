using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Class_Student
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string facultyNumber, string telephone, string email, string groupNumber, List<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Telephone = telephone;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
        }
        public List<int> Marks { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultyNumber { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string GroupNumber { get; set; }
    }
}
