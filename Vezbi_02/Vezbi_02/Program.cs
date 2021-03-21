using System;

namespace Vezbi_02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? areYouMajor = null;

            if (areYouMajor == true)
            {
                Console.WriteLine("It is Major");
            }
            else if (areYouMajor == false)
            {
                Console.WriteLine("It is not a Major");
            }
            else
            {
                Console.WriteLine("Did not answare the question");
            }
            Console.ReadLine();
        }
    }
}
