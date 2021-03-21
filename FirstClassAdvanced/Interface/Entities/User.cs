using Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Entities
{
    public abstract class User : IUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int GetAge()
        {
            return Age;
        }
        public abstract void SeyHi();
        public void SetName(string name)
        {
            Name = name;
        }

        //public void SeyHi()
        //{
        //    Console.WriteLine($"Hi My name is {Name}");
        //}
    }
}
