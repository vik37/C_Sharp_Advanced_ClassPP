using System;
using System.Collections.Generic;
using System.Text;
using Exemple.Entities.Interfaces;

namespace Exemple.Entities 
{
    public abstract class User : IUser
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public void PrintUser()
        {
            Console.WriteLine($"Id: {Id}, User Name: {UserName}, Name: {Name}");
        }
    }
}
