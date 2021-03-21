using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracAndtInterface.Entities
{
    public abstract class User
    {
        public User()
        {
            Console.WriteLine("User is born");
        }
        public string Name { get; set; }
        public int Age { get; set; } = 18;
        public abstract void SeyHi();
        public void FromAbstracted()
        {
            Console.WriteLine("Sey Hi From Abstract Class");
        }
       
    }
}
