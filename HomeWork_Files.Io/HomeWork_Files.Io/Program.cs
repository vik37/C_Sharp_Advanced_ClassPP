using HomeWork_Files.Io.Entities;
using HomeWork_Files.Io.Servicies;
using System;

namespace HomeWork_Files.Io
{
    class Program
    {
        static void Main(string[] args)
        {
            Users user1 = new Users();
            Users user2 = new Users();
            Users user3 = new Users();
            
            Console.WriteLine("Enter two numbers");
            user1.NumberOne = Console.ReadLine();
            user1.NumberTwo = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Enter another two numbers");
            user2.NumberOne = Console.ReadLine();
            user2.NumberTwo = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Enter again two numbers");
            user3.NumberOne = Console.ReadLine();
            user3.NumberTwo = Console.ReadLine();
            Console.WriteLine("=========================================================");
        
            user1.Result = Calculate.CalculateTwoNums(user1.NumberOne, user1.NumberTwo);
            user2.Result = Calculate.CalculateTwoNums(user2.NumberOne, user2.NumberTwo);
            user3.Result = Calculate.CalculateTwoNums(user3.NumberOne, user3.NumberTwo);
                                                 
            FoldersFilesPath files = new FoldersFilesPath();
            
            files.WriteResults(user1.Result, user2.Result, user3.Result);
            files.ReadResult();
           
            
            Console.ReadLine();
        }
    }
}
