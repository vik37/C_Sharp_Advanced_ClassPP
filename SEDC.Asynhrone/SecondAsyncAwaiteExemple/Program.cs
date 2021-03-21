using System;
using System.Threading;
using System.Threading.Tasks;

namespace SecondAsyncAwaiteExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = SendMessageAsynce("Hey there SEDC students!");
            ShowAd("Potato");
            Console.WriteLine(task.Status);
            Console.ReadLine();
        }
        public static async Task SendMessageAsynce(string message)
        {
            Console.WriteLine("Send Message!");

            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine($"The message {message} was sent!");
            });
        }

        public static void ShowAd(string product)
        {
            Console.WriteLine("While you wait let us show you an ad:");
            Console.Write("Buy the best product in the world ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(product);
            Console.ResetColor();
            Console.Write(" now and get ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("FREE");
            Console.ResetColor();
            Console.WriteLine(" shipping worldwide!");
            Console.ReadLine();
        }
    }
}
