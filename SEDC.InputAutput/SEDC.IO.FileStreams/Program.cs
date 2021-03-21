using System;
using System.IO;

namespace SEDC.IO.FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string directoryPAth = Path.Combine(currentDirectory, "NewFolder");
            string filePath = Path.Combine(directoryPAth, "NewText.txt");

            if (!Directory.Exists(directoryPAth))
            {
                Directory.CreateDirectory(directoryPAth);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            string[] users = { "user1", "user2", "user3" };
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Goa Trance and Psychedelic");
                sw.Write("Number of users:");
                sw.WriteLine(users.Length);

                Console.WriteLine("Writing complete.");
            }

            StreamWriter saw = new StreamWriter(filePath, true);

            saw.WriteLine("Appending new text.");
            Console.WriteLine("Writing second time complete.");
            saw.Close();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string firstLine = sr.ReadLine();
                string secondLine = sr.ReadLine();
                string thirdLine = sr.ReadLine();
                string fourthLine = sr.ReadLine();

                Console.WriteLine(firstLine);
                Console.WriteLine(secondLine);
                Console.WriteLine(thirdLine);
                

                if(fourthLine != null)
                {
                    Console.WriteLine("Fourth line is not null");
                }
            }
            Console.ReadLine();
        }
    }
}
