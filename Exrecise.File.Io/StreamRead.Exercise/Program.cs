using System;
using System.IO;

namespace StreamRead.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string directoryPath = $@"{currentDirectory}\NewFile";
            string filePath = Path.Combine(directoryPath, "NewText.txt");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            string[] users = { "User 1", "User2", "User3" };

            using(StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Hola Mutchatchos");
                sw.Write("Numbers of users: ");
                sw.WriteLine(users.Length);

                Console.WriteLine("Writing complete.");
            }

            StreamWriter sw1 = new StreamWriter(filePath, true);
            sw1.WriteLine("Append new text...");
            Console.WriteLine("Writing complete.");
            sw1.Dispose();

            using(StreamReader sr = new StreamReader(filePath))
            {
                string a = sr.ReadToEnd();
               // Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
