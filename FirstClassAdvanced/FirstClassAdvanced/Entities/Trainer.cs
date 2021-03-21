using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClassAdvanced.Entities
{
    public class Trainer : User
    {
        public string CurrentSubject { get; set; }
        public Trainer(int age = 18)
        {
            Age = age;
        }

        public override void SeyHi()
        {
            Console.WriteLine($"Hi my name is {Name}");
        }
    }
}
