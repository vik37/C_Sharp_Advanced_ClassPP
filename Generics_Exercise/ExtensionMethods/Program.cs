using ExtensionMethods.Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "viktor";
            string result = name.ChangeFirstLetterCase();
            //string result = StringHelper.ChangeFirstLetterCase(name);
            Console.WriteLine(result);

            Console.WriteLine("===========================================");

            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers,n => n % 2 == 0);
            //IEnumerable<int> EvenNumbers = Numbers.Where(n => n % 2 == 0);
            foreach (var num in EvenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
