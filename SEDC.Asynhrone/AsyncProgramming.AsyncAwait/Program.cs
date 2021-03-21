using System;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncProgramming.AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = SendMessageAsync("Hola!");
            Console.Write(x.Status);
            Console.ReadLine();
        }
        public static async void PrintMessageTask()
        {
            var result = await SendMessageAsync("Hola!");
            var result1 = await SendMessageAsync("Hola2!");

            Console.WriteLine(result);
            Console.WriteLine(result1);
        }

        public static async Task<string> SendMessageAsync(string message)
        {
            Console.WriteLine("Sending message.");

            return await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return $"Message is {message}";
            });
        }
    }
}
