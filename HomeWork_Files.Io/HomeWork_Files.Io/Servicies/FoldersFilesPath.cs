using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeWork_Files.Io.Servicies
{
    public class FoldersFilesPath
    {
        private string _currentDirectory;
        private string _directoryPath;
        private string _filePath;

        public FoldersFilesPath()
        {
            _currentDirectory = Directory.GetCurrentDirectory();
            _directoryPath = Path.Combine(_currentDirectory, "Exercise");
            _filePath = Path.Combine(_directoryPath, "Calculations.txt");
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
            
        }

        public void WriteResults(int numOne, int numTwo, int numThree)
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath);
            }
            using(StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.WriteLine($"Result 1: --- {numOne}");
                sw.WriteLine($"Result 2: --- {numTwo}");
                sw.WriteLine($"Result 3: --- {numThree}");
                
            }
           
        }
        public void ReadResult()
        {          
            using (StreamReader sr = new StreamReader(_filePath))
            {
                string firstLineText = sr.ReadLine();
                string secondLineText = sr.ReadLine();
                string thirdLineText = sr.ReadLine();
                Console.WriteLine(firstLineText);
                Console.WriteLine(secondLineText);
                Console.WriteLine(thirdLineText);
            }
        }
    }
}

