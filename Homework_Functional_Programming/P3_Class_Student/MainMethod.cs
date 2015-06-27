using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Class_Student
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Student ivan = new Student("Ivailo", "Petev", 28, "12356789", "+3592 87 799 083", "ivanIvanov@abv.bg", "10", new List<int>() { 6, 6, 5, 5 });
            Student pesho = new Student("Petyr", "Nikolov", 23, "234514578", "+359 287 799 993", "pesh0peshev@abv.bg", "2", new List<int>() { 6, 5, 5, 5 });
            Student peshev = new Student("Atanas", "Mitkov", 24, "534514578", "+359 987 799 993", "pesh0peshev@abv.bg", "2", new List<int>() { 6, 2, 5, 5 });
            Student penka = new Student("Asen", "Kirov", 27, "234524578", "+359 886 569 083", "penkaL@mail.bg", "2", new List<int>() { 2, 2, 4, 4 });
            Student dobri = new Student("Polina", "Atanasova", 22, "774514578", "02/ 886 569 083", "dobriKur@soft.bg", "2", new List<int>() { 3, 2, 2, 2 });
            List<Student> students = new List<Student>()
            {
                ivan,
                penka,
                pesho,
                dobri,
                peshev
            };

            //Problem 4
            var queryGroupNumberEqual2 =
                from student in students
                where student.GroupNumber.Equals("2")
                orderby student.FirstName
                select student;
            Console.WriteLine("Problem 4. Students by Group Number");
            foreach (var student in queryGroupNumberEqual2)
            {
                Console.WriteLine(student.FirstName + " " + student.GroupNumber);
            }

            //Problem 5
            var queryFirstNameAndLastName =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                orderby student.FirstName
                select student;
            Console.WriteLine("\nProblem 5. Students by First and Last Name");
            foreach (var student in queryFirstNameAndLastName)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 6
            var queryStudentsByAge =
                from student in students
                where student.Age > 18 && student.Age < 24
                select new { FirstName = student.FirstName, LastName = student.LastName };
            Console.WriteLine("\nProblem 6. Students by Age\n");
            foreach (var student in queryStudentsByAge)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 7
            var lambdaSortStudents = (students.OrderBy(student => student.FirstName).ThenBy(student => student.LastName)).Reverse();

            Console.WriteLine("\nProblem 7. Sort Students Lambda Expression");
            foreach (var student in lambdaSortStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine("\nProblem 7. Sort Students LINQ");
            var linqSortStudents =
                from student in students
                orderby (student.FirstName) descending, (student.LastName) descending
                select student;   
            foreach (var student in linqSortStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 8
            var queryFilterStudentsbyEmailDomain =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;
            Console.WriteLine("\nProblem 8. Filter Students by Email Domain");
            foreach (var student in queryFilterStudentsbyEmailDomain)
            { 
                Console.WriteLine(student.FirstName + " " + student.Email);
            }

            //Problem 9
            var queryFilterStudentsbyPhone =
                from student in students
                where student.Telephone.StartsWith("02") || student.Telephone.StartsWith("+3592") || student.Telephone.StartsWith("+359 2")
                select student;
            Console.WriteLine("\nProblem 9 Filter Students by Phone");
            foreach (var student in queryFilterStudentsbyPhone)
            {
                Console.WriteLine(student.FirstName + " " + student.Telephone);
            }

            //Problem 10
            var queryExcellentStudents =
                from student in students
                where student.Marks.Contains(6)
                select new { FirstName = student.FirstName, Marks = student.Marks };

            Console.WriteLine("\nProblem 10 Excellent Students");
            foreach (var student in queryExcellentStudents)
            {
                Console.Write(student.FirstName + " ");
                foreach (var mark in student.Marks)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }

            //Problem 11
            var queryWeakStudents =
                from student in students
                where student.Marks.Count(mark => mark == 2) > 1
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };
            Console.WriteLine("\nProblem 11. Weak Students");
            foreach (var student in queryWeakStudents)
            {
                Console.Write(student.FullName + " ");
                foreach (var mark in student.Marks)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }

            //Problem 12
            var queryStudentsEnrolledIn2014 =
                from student in students
                where student.FacultyNumber[4] == '1' && student.FacultyNumber[5] == '4'
                select student;
            Console.WriteLine(students.ElementAt(3).FacultyNumber[5]);
            Console.WriteLine("\nProblem 12. Students Enrolled in 2014");
            foreach (var student in queryStudentsEnrolledIn2014)
            {
                Console.WriteLine(student.FirstName + " " + student.FacultyNumber);
            }            
        }
    }
}
