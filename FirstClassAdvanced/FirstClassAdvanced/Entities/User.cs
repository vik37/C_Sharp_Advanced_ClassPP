using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClassAdvanced.Entities
{
    public abstract class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User()
        {
            Console.WriteLine("User is born");
         
        }
        //public void SayHi()
        //{
        //    Console.WriteLine($"Hi my name is {Name}");
        //}
        public abstract void SeyHi();
    }
}
