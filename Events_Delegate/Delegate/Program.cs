using System;

namespace Delegate
{
    class Program
    {
        public delegate void SayDelegate(string something);
        public delegate int NumbersDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            SayDelegate del = new SayDelegate(SayHello);
            SayDelegate by = new SayDelegate(SayBy);
            SayDelegate wow = new SayDelegate(x => Console.WriteLine($"wow {x}"));

            del("Bob");
            by("Jill");
            wow("John Doe");
            SayWhatever("Bob", SayHello);
            NumberMaster(2, 5, (x, y) => x + y);
            NumberMaster(2, 5, (x, y) => x - y);
            Console.ReadLine();
        }
        public static void SayHello(string person)
        {
            Console.WriteLine($"Hello {person}");
        }
        public static void SayBy(string person)
        {
            Console.WriteLine($"Bye {person}");
        }
        public static void SayWhatever(string whatever, SayDelegate seyDell)
        {
            Console.WriteLine($"Chat bob say: ");
            seyDell(whatever);
        }
        public static void NumberMaster(int num1,int num2, NumbersDelegate numDelegate)
        {
            Console.WriteLine($"Resalt is: {numDelegate(num1,num2)} ");
        }
    }
}
