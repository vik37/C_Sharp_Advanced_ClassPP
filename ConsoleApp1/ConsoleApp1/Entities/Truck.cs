using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    public class Truck : Wheecles, ITruck, ISpeed
    {
        public decimal Weight { get; set; }
        public string ClassOfTruck { get; private set; }
        private int Speed { get; set; }
        public Truck()
        {
          
        }
        public Truck(int id,string name,string type, string color, decimal weight)             
        {
            Weight = weight;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} | Truck Name: {Name} | Type of track: {Type} | Truck color: {Color}");
        }

        
        public string Classes()
        {
            if(Weight < 7258.85M)
            {
                return ClassOfTruck = "Light Truck";
            }
            else if(Weight > 7258.85M)
            {
                return ClassOfTruck = "Medium Truck";
            }
            else if(Weight > 11796.23M)
            {
                return ClassOfTruck = "Havy Truck";
            }
            else
            {
                return ClassOfTruck = "Weidth Empty";
            }
        }

        public void ShowClass()
        {
            Classes();
            Console.WriteLine($"Truck Weight Class: {ClassOfTruck}"); 
        }
        public int ReturnSpeed()
        {
            if (ClassOfTruck == "Light Truck")
            {
               return Speed = 160;
            }
            else if (ClassOfTruck == "Medium Truck")
            {
               return Speed = 120;
            }
            else if (ClassOfTruck == "Havy Truck")
            {
               return Speed = 90;
            }
            else
            {
               return Speed = 0;
            }
        }

        public void ShowSpeed()
        {
            ReturnSpeed();
            Console.WriteLine($"Maximum speed - {Speed} km/h");
        }
    }
}
