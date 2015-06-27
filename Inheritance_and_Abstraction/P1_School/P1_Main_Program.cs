using System;
using System.Collections.Generic;
namespace P1_School
{
    class P1_Main_Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            List<Disciplines> disciplines = new List<Disciplines>();
            Students Pesho = new Students("Pesho", 10, "level #1");
            Students Minka = new Students("Minka", 33, "Level #0");
            Students Gosho = new Students("Gosho", 100, "Level #2");
            students.Add(Pesho);
            students.Add(Minka);
            
            Disciplines cSharp = new Disciplines("CSharp", 100, students);
            Disciplines php = new Disciplines("PHP", 300, students);
            disciplines.Add(cSharp);
            disciplines.Add(php);


            Teacher Nik = new Teacher("Nikolai", "11087", disciplines);
            Teacher Gatakka = new Teacher("Gatakka", "11087", disciplines);
            List<Teacher> teachers = new List<Teacher> { };
            teachers.Add(Nik);
            teachers.Add(Gatakka);

            Classes level2 = new Classes("Level #2", teachers);
            Console.WriteLine("\t\t\tClass name: " + level2.TextID);
            foreach(var teacher in level2.GetTeacher())
            {
                Console.WriteLine("Teacher name: {0}; \t\t\t\tTeacher id: {1} \n\t\t\t\tDiscipline: ", teacher.Name, teacher.ID);
                foreach(var discipline in teacher.GetDisciplines())
                {
                    Console.WriteLine("Discipline Name: {0} \t\t\t\tNumber of lectures: {1}", discipline.Name, discipline.NumberOfLectures);
                    Console.WriteLine("\t\t\t\tStudents: ");
                    foreach(var student in discipline.GetStudents())
                    {
                        Console.WriteLine("Student name: {0} \t\t\t\tStudent ID: {1}",student.Name, student.NumInClass);
                        
                    }
                }
                Console.WriteLine("\n");
                
            }
            
        }
    }
}
