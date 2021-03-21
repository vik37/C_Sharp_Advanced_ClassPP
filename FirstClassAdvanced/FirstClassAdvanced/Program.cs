using System;
using FirstClassAdvanced.Entities;


namespace FirstClassAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user = new User();
            User student = new Student() { Name = "Viktor"};
            User trainer = new Trainer(19);
            User assistent = new Assistent();
            
            Console.ReadLine();
        }
    }
}
