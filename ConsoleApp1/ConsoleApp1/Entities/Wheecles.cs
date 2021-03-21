using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    public abstract class Wheecles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public Wheecles()
        {
           
        }
        public Wheecles(int id, string name, string type, string color)
        {
            Id = id;
            Name = name;
            Type = type;
            Color = color;
        }
        public abstract void ShowInfo();
       
    }
}
