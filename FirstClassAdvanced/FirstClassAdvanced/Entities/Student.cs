using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClassAdvanced.Entities
{
    public class Student : User
    {
        public int Group { get; set; }
        public override void SeyHi()
        {
            Console.WriteLine($"Hi my name is {Name}");
        }
    }
}
