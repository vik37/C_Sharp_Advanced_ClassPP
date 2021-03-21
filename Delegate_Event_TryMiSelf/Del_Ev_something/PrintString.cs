using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Del_Ev_something
{
    public class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;

        public delegate void PrintToStr(string s);

        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        public static void PrintToFile(string s)
        {
            fs = new FileStream(@"C:\Users\vikto\OneDrive\Documents\CSharp\edabre.txt",
                FileMode.Append,FileAccess.Write);

            sw = new StreamWriter(fs);
            sw.Write(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static void SendString(PrintToStr ps)
        {
            ps("Hello Worls. Don't FUCK WITH ME");
        }
    }
}
