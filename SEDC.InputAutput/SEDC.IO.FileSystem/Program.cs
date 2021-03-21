using System;
using System.IO;

namespace SEDC.IO.FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);

            string directoryPAth = Path.Combine(currentDirectory,"NewFolder");

            //if (!Directory.Exists(directoryPAth))
            //{
            //    Directory.CreateDirectory(directoryPAth);
            //    Console.WriteLine($"Directory {directoryPAth} created");
            //}
            //PrintDirectoryExists(directoryPAth);
            //if (Directory.Exists(directoryPAth))
            //{
            //    Directory.Delete(directoryPAth);
            //    Console.WriteLine($"Directory {directoryPAth} delated");
            //}
            //PrintDirectoryExists(directoryPAth);

            string filePath = Path.Combine(directoryPAth, "NewText.txt");
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            //if (File.Exists(filePath))
            //{
            //    File.Delete(filePath);
            //}

            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, "Hola Mundo!");
            }
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);

                Console.WriteLine(content);
            }


            Console.ReadLine();
        }

        public static void PrintDirectoryExists(string path)
        {
            if (Directory.Exists(path))
            {
                Console.WriteLine($"Directory {path} exist.");
            }
            else
            {
                Console.WriteLine($"Directory {path} does not exsist. exist.");
            }
        }
    }
}
