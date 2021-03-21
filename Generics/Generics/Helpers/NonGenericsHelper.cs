using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Helpers
{
    public static class NonGenericsHelper
    {
        public static void GoTrough(List<string> strings)
        {
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
        }
        public static void GetInfo(List<string> strings)
        {

            string str = strings[0];
                Console.WriteLine($"The List has {strings.Count} of type {str.GetType().FullName}");
            
        }
        public static void GoTrough(List<int> strings)
        {
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
        }
        public static void GetInfo(List<int> strings)
        {

            int str = strings[0];
            Console.WriteLine($"The List has {strings.Count} of type {str.GetType().FullName}");

        }
    }
}
