using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.CLass11.SerializationDeserialization.Servicies
{
    public class ReadWriteService
    {
        public void WriteFile(string path,string data)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(data);
            }
            Console.WriteLine("Successfully written to a file.");
        }

        public string ReadFile(string path)
        {
            string result = "";

            if (!File.Exists(path))
            {
                return "File does not exist.";
            }

            using(StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }
            Console.WriteLine("Successfully read a file.");
            return result;
        }
    }
}
