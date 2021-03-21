using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateAsync();
            CalculateThree();
            Console.ReadLine();
        }
        public async static void CalculateAsync()
        {
            var result = await Task.Run(() =>
            {
                return CalculateOne();
            });
            CalculateTwo(result);
        }
        public static int CalculateOne()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Calculating in method1");
            return 100;
        }
        public static int CalculateTwo(int number)
        {
            Console.WriteLine($"Calculate in method 2");
            return 200;
        }
        public static int CalculateThree()
        {
            Console.WriteLine("Calculate in method 3");
            return 300;
        }
    }
}
