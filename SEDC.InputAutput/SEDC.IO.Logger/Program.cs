using SEDC.IO.Logger.Entities;
using SEDC.IO.Logger.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.IO.Logger
{
    class Program
    {
        static List<User> Users = new List<User>
        {
            new User(){ Id = 1, UserNAme = "John Doe",Password = "1234",Age = 20},
            new User(){Id = 2,UserNAme = "Jill Doe",Password = "56789",Age = 22 },
            new User(){ Id = 3,UserNAme = "Jane Doe", Password = "Abreumre",Age = 29}
        };
        public static int LogIn(string username,string password)
        {
            User user = Users.SingleOrDefault(user =>
                 user.UserNAme == username && user.Password == password);

            if(user == null)
            {
                throw new InvalidUserException("Invalid credentials.");
            }
            Console.WriteLine($"Welcome {user.UserNAme}");
            return user.Id;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome.");
            Console.WriteLine("Enter User:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            LogIn(username, password);

            Console.ReadLine();
        }
    }
}
