using System;

namespace Adv._06.Delegates
{
	class Program
	{
        // Declaring delegates
        // This is the signature of any method that we want this delegate to point to
        public delegate void SayDelegate(string something);
        public delegate int NumbersDelegate(int num1, int num2);
        static void Main(string[] args)
        {
			#region Instantiating a delegate with methods
			SayDelegate del = new SayDelegate(SayHello); // The SayDelegate points to SayHello
            SayDelegate bye = new SayDelegate(SayBye); // The SayDelegate points to SayBye
            SayDelegate wow = new SayDelegate(x => Console.WriteLine($"Wow {x}!")); // The SayDelegate points to an anonymous method

            // Using the delegate ( Points to methods )
            del("Bob");
            bye("Jill");
            wow("Greg");
			#endregion

			#region Passing a method to a delegate parameter
			SayWhatever("Bob", SayHello);
            SayWhatever("Jill", SayBye);
            SayWhatever("Greg", x => Console.WriteLine($"Wow {x}!"));
            SayWhatever("Anne", x =>
            {
                Console.WriteLine($"Stuff with {x}");
                Console.WriteLine($"Other stuff with {x}");
            });
			#endregion
			#region Making a high order method
			Console.WriteLine("NUMBER MASTER! IT IS REALLY MASTER AT NUMBERS!");
            NumberMaster(2, 5, (x, y) => x + y);
            NumberMaster(2, 5, (x, y) => x - y);
            NumberMaster(2, 5, (x, y) => 0);
            NumberMaster(2, 5, (x, y) =>
            {
                if (x > y) return x;
                return y;
            });
			#endregion
			Console.ReadLine();
        }
        public static void SayWhatever(string whatever, SayDelegate sayDel)
        {
            Console.Write("Chatbot says:");
            sayDel(whatever);
        }
        public static void NumberMaster(int num1, int num2, NumbersDelegate numberDel)
        {
            Console.WriteLine($"The result is: {numberDel(num1, num2)}");
        }
        public static void SayHello(string person)
        {
            Console.WriteLine($"Hello {person}!");
        }
        public static void SayBye(string person)
        {
            Console.WriteLine($"Bye {person}!");
        }
    }
}
