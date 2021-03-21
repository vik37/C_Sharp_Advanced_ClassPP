using InterfaceProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProject.Entities
{
    public class Costumer : ICostumer
    {
        public void I2Method()
        {
            Console.WriteLine("I2 Method");
        }

        public void Print()
        {
            Console.WriteLine("Interface Print Method");

        }
    }
}
