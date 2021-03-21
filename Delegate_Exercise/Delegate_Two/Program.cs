using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Delegate_Two
{
    public delegate void SimpleDelegate(string name);
    public delegate int SumOfTwo(int number1, int number2);
    class Program
    {
        static void Main(string[] args)
        {
            SimpleDelegate del = new SimpleDelegate(Some);
            
            Some("Viktor");

            SumOfTwo(1, 2, (x, y) => x + y);
            Console.ReadLine();
        }
        static void Some(string s)
        {
            Console.WriteLine($"My name is {s}");
        }
        static void SumOfTwo(int num1,int num2,SumOfTwo sum)
        {
            Console.WriteLine($"The result is: {sum(num1,num2)}");
        }
    }
}
