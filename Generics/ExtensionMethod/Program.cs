using ExtensionMethod.Helpers;
using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello from G1, we are learning C# Advanced";
            //var result = stringHelper.Shorten(text, 5);
            var result = text.Shorten(5);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
