using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SerializeDeserialize
{
    public class ReadWrite
    {
        public string CurrentDirectory { get; set; }
        public string FolderPath { get; set; } 
        public string FilePath { get; set; }
        public string FileText { get; set; }

        public ReadWrite()
        {
            CurrentDirectory = Directory.GetCurrentDirectory();
            FolderPath = @$"{CurrentDirectory}\NewFolder";
            
            FileText = Path.Combine(FolderPath, "SOmething.txt");
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory("NewFolder");
            }
        }

        public void WriteJson(string data)
        {
            FilePath = Path.Combine(CurrentDirectory,"Json.json");
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.WriteLine(data);
            }
        }

        public void WriteFile()
        {
            
            if (!File.Exists(FileText))
            {
                File.Create(FileText);
            }

            using(StreamWriter sw = new StreamWriter(FileText,true))
            {
                sw.WriteLine(FilePath);
            }
        }
        public string RideFile()
        {
            string result = "";
            if (!File.Exists(FilePath))
            {
                return "File does not exist";
            }
            if (!File.Exists(FileText))
            {
                return "File does not exist";
            }
            using(StreamReader sr = new StreamReader(FilePath))
            {
                result = sr.ReadToEnd();
            }
            using(StreamReader sr = new StreamReader(FileText))
            {
                result = sr.ReadToEnd();
            }
            return result;
            
        }
    }
}
