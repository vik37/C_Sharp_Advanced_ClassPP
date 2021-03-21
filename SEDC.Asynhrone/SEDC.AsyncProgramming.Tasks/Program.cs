using System;
using System.Threading;
using System.Threading.Tasks;

namespace SEDC.AsyncProgramming.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("App started.");
            //Task taskOne = new Task(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Running after 2000 ms");
            //});

            //taskOne.Start();

            //Task<int> valueTask = new Task<int>(() =>
            //{
            //    Thread.Sleep(4000);
            //    return 3 + 3;

            //});

            //valueTask.Start();
            //Console.Write($"RESULT: {valueTask.Result}");

            for (int i = 10; i >= 0; i--)
            {
                var index = i;

                var result = Task<string>.Run(() =>
                {
                    Thread.Sleep(1000);
                    return $"Task number {index}";
                });

                Console.WriteLine(result.Result);
                if(index == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("HAPPY NEW YEAR!!!!");
                    Console.ResetColor();
                }
            }
            Console.ReadLine();
        }
    }
}
