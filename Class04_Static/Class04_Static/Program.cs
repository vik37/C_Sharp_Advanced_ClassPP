using Class04_Static.Entities;
using System;

namespace Class04_Static
{
    class Program
    {
        static User _currentUser;
        static void Main(string[] args)
        {
            Order order = new Order();
            OrdersTempDB.ListOfUsers();
            //OrdersTempDB.InsertOrder(1,_currentUser);
            Console.ReadLine();
        }
    }
}
