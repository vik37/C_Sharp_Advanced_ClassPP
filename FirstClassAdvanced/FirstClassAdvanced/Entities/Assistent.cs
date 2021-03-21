using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClassAdvanced.Entities
{
    public class Assistent : User
    {
        public string[] HomeWorks { get; set; }
        public override void SeyHi()
        {
            Console.WriteLine($"Hi my name is {Name}");
        }
    }
}
