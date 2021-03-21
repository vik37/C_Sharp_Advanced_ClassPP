using System;
using System.IO;

namespace Something.InputOutput.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string directoryPath = $@"{currentDirectory}\NewFolder";

            //PrintIfDirectoryExists(directoryPath);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine($"Directory {directoryPath} created.");
            }

            //PrintIfDirectoryExists(directoryPath);

            //if (Directory.Exists(directoryPath))
            //{
            //    Directory.Delete(directoryPath);
            //    Console.WriteLine($"Directory {directoryPath} deleted.");
            //}


            string filePath = Path.Combine(directoryPath, "NewText.txt");

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, "Write something from here...");
            }
            //Console.WriteLine(filePath);

            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            PrintTextFromMethod(directoryPath);
            Console.ReadLine();
        }
        static void PrintTextFromMethod(string path)
        {
            if (Directory.Exists(path))
            {
                Console.WriteLine($"Directory {path} exists.");
            }
            else
            {
                Console.WriteLine($"Directory {path} not exist exists.");
            }
        }
    }
}
