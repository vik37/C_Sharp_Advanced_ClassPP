using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractCLassProject.Entities
{
    public abstract class Human
    {
        public string FullName { get; set; }
       
        public int Age { get; set; }
        public long Phone { get; set; }

        public abstract string GetInfo();
        public Human(string fullName, int age, long phone)
        {
            FullName = FullName;
            Age = age;
            Phone = phone;

        }
        public void Greet(string name)
        {
            Console.WriteLine($"Hey there {name}! My name is {FullName}!");
        }

        
    }
}
