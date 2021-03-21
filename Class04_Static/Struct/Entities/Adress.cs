using System;
using System.Collections.Generic;
using System.Text;

namespace Struct.Entities
{
    // A struct can be used:
    // When the only reason we need the entity is to store some data
    // When we want to pass the data by value instead of by reference
    // When we know that we will never use the entity as a business logic tree ( Inheritance )
    // When all members are a value type ( int, string, bool etc. )
    public struct Adress
    {
        public string Street { get; set; }
        public int Number { get; set; }
   
        public Adress(string street,int number)
        {
            Street = street;
            Number = number;
           
        }
        public string GetFullAddress()
        {
            return $"{Street} No. {Number}";
        }
    }
}
