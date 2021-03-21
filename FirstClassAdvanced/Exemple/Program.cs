using Exemple.Entities;
using System;
using System.Collections.Generic;

namespace Exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Id = 1,
                Name = "John",
                Password = "123",
                UserName = "John Do",
                Grades = new List<int>() { 5, 5, 5, 5 }
            };
           
            Teacher teacher1 = new Teacher()
            {
                Id = 2,
                Name = "Viktor",
                Password = "Nisto Neznam",
                UserName = "Viko",
                Subjects = { "CSS", "HTML", "JavaScript", "C#" }
            };
            student1.PrintUser();
            Console.WriteLine("---------------");
            teacher1.PrintUser();
            Console.WriteLine("_________________________");
           
            Console.WriteLine("SUBJECT: ");
            Console.WriteLine("---------------");
            student1.ShowGrades();
            
            Console.WriteLine("_________________________");
            Console.WriteLine("GRADES: ");
            Console.WriteLine("---------------");
           
            teacher1.PrintSubject();
            Console.WriteLine("_________________________");
            var studentsGrades = student1.Grades;
            var subjects = teacher1.Subjects;
            teacher1.subjectWithGrades.Add(subjects, studentsGrades);
            teacher1.PrintSubjectsWithGrades();
            Console.WriteLine("_________________________");
            student1.Names.Add(student1.Name);
            
            var studentNames = student1.Names;
            teacher1.StudentWithGrades.Add(studentNames, teacher1.subjectWithGrades);
            teacher1.PrintAllStudentsWithGrades();
            //student1.PrintNames();
            Console.ReadLine();
        }
    }
}
