using System;
using System.Threading;

namespace SEDC.AsyncProgrammingTrade
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintMessage();
            PrintMessageWithTreads();
            Console.ReadLine();
        }
       
        public static void PrintMessage()
        {
            Console.WriteLine("Get Ready!");
            Thread.Sleep(6000);
            Console.WriteLine("First Message.");
            Thread.Sleep(2000);
            Console.WriteLine("Second Message.");
            Console.ReadLine();
        }
        public static void PrintMessageWithTreads()
        {
            Console.WriteLine("Get Ready!");

            Thread threadOne = new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("First message.");
            });

            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Second Message.");
            }).Start();

            Thread.Sleep(4000);
            threadOne.Start();
            Console.ReadLine();

        }
    }
}
