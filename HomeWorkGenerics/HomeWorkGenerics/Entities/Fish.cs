using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGenerics.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public double Size { get; set; }
        public override string PrintInfo()
        {

            return $"Name: {Name}, Type: {Type}, Age: {Age} \n Color: {Color} | Size: {Size}cm";
        }
    }
}
