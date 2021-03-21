using AbstracAndtInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracAndtInterface.InheritClasses
{
    public class Assistant : User
    {
        public string[] HomeWrork { get; set; }
        public override void SeyHi()
        {
            Console.WriteLine($"Hi my name is {Name} and I am assistant");
        }
    }
}
