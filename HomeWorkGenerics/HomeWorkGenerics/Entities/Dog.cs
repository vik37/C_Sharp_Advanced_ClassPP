using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGenerics.Entities
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }
        public override string PrintInfo()
        {
            return $"Name: {Name}, Type: {Type}, Age: {Age} \n Favorite Food - {FavoriteFood} | Is it Good: {GoodBoy}";

        }
    }
}
