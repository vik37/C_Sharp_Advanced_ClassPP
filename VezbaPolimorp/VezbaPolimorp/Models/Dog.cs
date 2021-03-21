using System;
using System.Collections.Generic;
using System.Text;

namespace VezbaPolimorp.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public static bool Validate(Dog dog)
        {
            if(dog.Id < 0 
                && string.IsNullOrWhiteSpace(dog.Name)
                && string.IsNullOrWhiteSpace(dog.Name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public  void Bark()
        {
            Console.WriteLine("Bark Bark");
        }
    }
}
