using System;

delegate int NumChanget(int n);
namespace Del_Ev_something
{
    class Program
    {
        static void Main(string[] args)
        {
            NumChanget nc;
            NumChanget nc1 = new NumChanget(Sample.AddNum);
            NumChanget nc2 = new NumChanget(Sample.MultNum);

            nc1(25);
            Console.WriteLine("Value of Num: {0}", Sample.GetNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", Sample.GetNum());

            Console.WriteLine("-------------{0}------", Sample.GetNum());

            nc = nc1;
            nc1 += nc2;
            nc(5);
            Console.WriteLine("Value of Num: {0}", Sample.GetNum());

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("===================================================================", Sample.GetNum());
            Console.ResetColor();

            PrintString.PrintToStr print1 = new PrintString.PrintToStr(PrintString.WriteToScreen);
            PrintString.PrintToStr print2 = new PrintString.PrintToStr(PrintString.PrintToFile);
            PrintString.SendString(print1);
            PrintString.SendString(print2);
            Console.ReadLine();
        }

    }
}
