using ConsoleApp1.Helper;
using ConsoleApp1.Interface;

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    public class Car : Wheecles, ICar,ISpeed
    {
        public int YearOfProduction { get; set; }
        private int Old { get; set;  }
        public int MaxSpeed { get; set; }
        public Car()
        {
            
        }
        public Car(int id, string name, string type, string color,int yearsOfProduction,int old,int maxSpeed)
        {
            YearOfProduction = yearsOfProduction;
            
        }
       
        public override void ShowInfo()
        {
            Console.WriteLine($"Car Id: {Id}, Car Name: {Name}, Car Type: {Type}, Car Color: {Color}");
        }

        public void SHowAge()
        {
            Old = Old.SetYear(YearOfProduction);
            Console.WriteLine($"Car {Name} is {Old} years old. Product {YearOfProduction} year");
        }

        public void ShowSpeed()
        {
            Console.WriteLine($"Maximum Speed: {MaxSpeed}kmph");
        }
    }
}
