using AbstracAndtInterface.Entities;
using AbstracAndtInterface.InheritClasses;
using System;

namespace AbstracAndtInterface
{
    class Program
    {
        static void Main(string[] args)
        {
           Assistant user = new Assistant();
            user.Name = Console.ReadLine();
            user.FromAbstracted();

            Console.ReadLine();
        }
    }
}
