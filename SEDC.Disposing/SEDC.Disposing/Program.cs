using System;
using System.IO;

namespace SEDC.Disposing
{
    class Program
    {
        public static string appPath = "..\\..\\..\\Text";
        public static string appFile = appPath + "\\text.txt";

        public static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        public static void CreateFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
        public static void WriteTextInFile(string text,string path)
        {
            using (var sw = new StreamWriter(path,true))
            {
                sw.WriteLine(text);
            }
        }
        public static void WriteTextInFileManuel(string text, string path)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(text);
            sw.Close();
            sw.Dispose();
        }
        public static void ReadTextInFileManuel(string text, string path)
        {
            StreamReader sr = new StreamReader(path);
            Console.WriteLine(sr.ReadToEnd());
            sr.Dispose();
        }
        public static void ReadTextFromFile(string path)
        {
            using (var sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        public static void WriteAndReadInFileExample()
        {
            try
            {
                Console.WriteLine("Please enter text for pt1:");
                string text1 = Console.ReadLine();
                // WriteTextInFile(text1, appFile);
                // WriteTextInFileManuel(text1, appFile);
                WriteTextInFileInplementation(text1, appFile);
                Console.WriteLine("Please enter text for pt2:");
                string text2 = Console.ReadLine();
                //WriteTextInFile(text2, appFile);
                // WriteTextInFileManuel(text2, appFile);
                WriteTextInFileInplementation(text2, appFile);
                Console.WriteLine("Please enter text for pt3:");
                string text3 = Console.ReadLine();
                // WriteTextInFile(text3, appFile);
                //WriteTextInFileManuel(text3, appFile);
                WriteTextInFileInplementation(text3, appFile);
            }
            catch (Exception ex)
            {

                Console.WriteLine("There was a problem in the writing file.");
                Console.WriteLine(ex.Message);
            }
           

            Console.Clear();
            Console.WriteLine("----------You entered----------");
            try
            {
                ReadTextFromFile(appFile);
            }
            catch (Exception ex)
            {

                Console.WriteLine("There was a problem in the reading file.");
                Console.WriteLine(ex.Message);
            }
            
        }
        public static void WriteTextInFileInplementation(string text,string path)
        {
            using(var ow = new CustomReaderWriter(path))
            {
                ow.WriteInFile(text);
            }
        }
        static void Main(string[] args)
        {
            CreateFolder(appPath);
            CreateFile(appFile);

            WriteAndReadInFileExample();
            Console.ReadLine();
        }
    }
}
