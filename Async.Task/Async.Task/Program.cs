using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 0; i--)
            {
                var index = i;

                var result = Task<string>.Run(() =>
                {
                    Thread.Sleep(1000);
                    return $"Task number {index}";
                });

                Console.WriteLine(result.Result);
                if (index == 0)
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
