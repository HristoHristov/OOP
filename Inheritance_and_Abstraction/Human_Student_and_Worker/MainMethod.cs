using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Human_Student_and_Worker
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            string[] studentsFirstName = { "Radko", "Nasko", "Pesho", "Misho", "Blagojka", "Misha", "Sashka", "Silvi", "Milen", "Ivan" };
            string[] studentsLastName = { "Radkov", "Naskov", "Peshov", "Mishov", "Blagojkava", "Mishava", "Sishkav", "Silviev", "Milenova", "Ivanov" };
            string[] studentsFacultyNum = { "10000", "99999", "99919", "99929", "99909", "99959", "99969", "99119", "99999", "99949" };

            string[] workerFirstName = { "Radko", "Nasko", "Pesho", "Misho", "Blagojka", "Misha", "Sashka", "Silvi", "Milen", "Ivan" };
            string[] workerLastName = { "Radkov", "Naskov", "Peshov", "Mishov", "Blagojkava", "Mishava", "Sishkav", "Silviev", "Milenova", "Ivanov" };
            double[] workerWeekSalary = { 100, 120, 300, 200, 123, 134, 235, 136, 137, 144 };
            double[] workerWorkHoursPerDay = { 8, 7, 8, 10, 12, 15, 18, 20, 9, 10 };

            for (int i = 0; i < studentsFirstName.Length; i++)
            {
                Student asdf = new Student(studentsFirstName[i], studentsLastName[i], studentsFacultyNum[i]);
                Worker asdfg = new Worker(workerFirstName[i], workerLastName[i], workerWeekSalary[i], workerWorkHoursPerDay[i]);
            }
            
            foreach(var student in Student.SortingStudent())
            {
                Console.WriteLine("Student Name: {0} - Student Faculty Number: {1}", student.FirstName, student.FacultyNumber);
            }

            Console.WriteLine("---------------------------------------------------");

            foreach(var worker in Worker.Sorting())
            {
                Console.WriteLine("Worker Name: {0} - Salary: {1}", worker.FirstName, worker.MoneyPerHour());
            }

            Console.WriteLine("\nSorting By First Name\n");
            
            foreach(var sortFirstName in SortingMergeObjects.SortingMergeObjectByFirstName())
            {
                Console.WriteLine(sortFirstName.FirstName);
            }

            Console.WriteLine("\nSorting by Last Name:\n");

            foreach(var sortingLastName in SortingMergeObjects.SortingMergeObjectByLastName())
            {
                Console.WriteLine(sortingLastName.LastName);
            }

        }
    }
}
