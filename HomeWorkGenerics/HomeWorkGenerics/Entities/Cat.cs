using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGenerics.Entities
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }
        public override string PrintInfo()
        {

            return $"Name: {Name}, Type: {Type}, Age: {Age} \n Lazy - {Lazy} | Lives Left {LivesLeft}";

        }
    }
}
