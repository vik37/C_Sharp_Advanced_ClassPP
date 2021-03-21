using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Helper
{
    public static class SumAge
    {
        public static DateTime year = DateTime.Now;
        public static int SetYear(this int result, int YearOFProduct)
        {
                       
            int toYear = year.Year;

            result = (toYear - YearOFProduct);
            return result;
            
        }
    }
}
