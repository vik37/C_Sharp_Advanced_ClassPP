using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SerializeDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Students studentOne = new Students()
            {
                FullName = "Viktor Zafirovski",
                Age = 37,
                Subject = new List<string>() { "HTML", "CSS", "JavaScript", "C#", "MVC", "SQL" }
            };
            Students studentTwo = new Students()
            {
                FullName = "Darko Pancev",
                Age = 46,
                Subject = new List<string>() { "Azura", "Python", "PHP", "Java" }
            };
            SaveClasses sv = new SaveClasses();
            sv.ReturnStudents(studentOne);
            sv.ReturnStudents(studentTwo);

            ReadWrite rw = new ReadWrite();

            string json = JsonConvert.SerializeObject(sv);
            //rw.WriteJson(json);

            string secondJson = JsonConvert.SerializeObject(studentOne);
            rw.WriteJson($"{json}, {secondJson}");
            Console.WriteLine(json);

            Console.ReadLine();
        }
    }
}
