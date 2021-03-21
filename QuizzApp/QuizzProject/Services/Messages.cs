using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzProject.Services
{
    public class Messages
    {
        public static void ShowMessages(string message,ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }
    }
}
