using AbstracAndtInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracAndtInterface.InheritClasses
{
    public class Teacher : User
    {
        public Teacher()
        {
            Console.WriteLine("Trainer is born");

        }
        public string CurrentSubject { get; set; }

        public override void SeyHi()
        {
            Console.WriteLine($"Hi my name is {Name} and I'm trainer");
        }
    }
}
