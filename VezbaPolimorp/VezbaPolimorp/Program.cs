using System;
using VezbaPolimorp.Models;

namespace VezbaPolimorp
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Create a class called Dog that has:
            //Id, Name, Color, Bark() - Prints “Bark Bark”
            //A static method Validate() - Checks if dog has all 3 properties, if Id is not less than 0 and Name is 2 characters or longer
            //Create a static class called DogShelter that has:
            //List of Dogs
            //PrintAll() - prints all dogs from List of Dogs
            //Create 3 Dog objects, call validate on them to see if they are okay, add them in the List of Dogs and call PrintAll()

            var dog = new Dog()
            {
                Id = 1,
                Name = "Kim",
                Color = "Brown"
            };

            Console.WriteLine("Hello World!");
        }
    }
}
