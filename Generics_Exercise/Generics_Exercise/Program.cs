using System;

namespace Generics_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool equal = Calculator<string>.AreEqual("ab", "ab");
            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            Console.ReadLine();
        }
    }
    public class Calculator<T>
    {
        public static bool AreEqual(T value1,T value2)
        {
            //return value1 == value2;
            return value1.Equals(value2);
        }
    }
}
