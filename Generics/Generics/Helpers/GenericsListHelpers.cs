using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Helpers
{
    public static class GenericsListHelpers<T>
    {
        public static void GoTrough(List<T>list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            
            }
        }
        public static void GetInfo(List<T>list)
        {
           
                var item = list[0];
                Console.WriteLine($"The List has {list.Count} of type {list.GetType().FullName}");
            
        }
    }
}
