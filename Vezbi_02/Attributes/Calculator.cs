using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    public class Calculator
    {
        [Obsolete ("Use Add(List<int>numbers) Method")]
        public static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        public static int Add(List<int> numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum = sum + num;
            }
            return sum;
        }
    }
}
