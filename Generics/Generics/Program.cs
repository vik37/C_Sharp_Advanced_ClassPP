using Generics.Helpers;
using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() { "str1", "str2", "str3", "str4" };
            NonGenericsHelper.GoTrough(strings);
            NonGenericsHelper.GetInfo(strings);
            List<int> numbers = new List<int>() { 1,2,3,4,5};
            NonGenericsHelper.GoTrough(numbers);
            NonGenericsHelper.GetInfo(numbers);
            List<bool> boolean = new List<bool>() { true, true, false, false, true };
            GenericsListHelpers<string>.GetInfo(strings);
            GenericsListHelpers<int>.GetInfo(numbers);
            GenericsListHelpers<bool>.GetInfo(boolean);
            Console.ReadLine();
        }
    }
}
