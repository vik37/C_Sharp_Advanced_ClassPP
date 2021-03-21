using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeWork_Files.Io.ExceptionsText
{
    public class Errors
    {
        private string _currentDirectory;
        private string _directoryPath;
        private string _filePath;
        public Errors()
        {
            _currentDirectory = Directory.GetCurrentDirectory();
            _directoryPath = Path.Combine(_currentDirectory, "Exceptions Folder");
            _filePath = Path.Combine(_directoryPath, "Exceptions.txt");
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
        }
        public void ErrorsCathText(string messages)
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath);
            }
            StreamWriter sw = new StreamWriter(_filePath, true);
            sw.WriteLine(messages);
            sw.Dispose();
        }
    }
}
