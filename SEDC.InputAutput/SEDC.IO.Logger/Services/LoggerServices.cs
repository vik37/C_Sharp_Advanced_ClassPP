using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.IO.Logger.Services
{
    public class LoggerServices
    {
        private string _logsDirectory;
        private string _errorCountPath;
        private string _logsPath;

        public LoggerServices()
        {
            _logsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
            _errorCountPath = Path.Combine(_logsDirectory,"ErrorCount.txt");
            _logsPath = Path.Combine(_logsDirectory, "Log.txt");

            if (!Directory.Exists(_logsDirectory))
            {
                Directory.CreateDirectory(_logsDirectory);
            }
        }

        public void Log(string error, string message, string username = "unknown user")
        {
            if (!File.Exists(_logsPath))
            {
                File.Create(_logsPath);
            }

            using(StreamWriter sw = new StreamWriter(_logsPath, true))
            {
                sw.WriteLine($"[ERROR]: {error}");
                sw.WriteLine($"[TIMESTAMP]: {DateTime.Now.ToLocalTime()}");
                sw.WriteLine($"[USER]: {username}");
                sw.WriteLine($"[MESSAGE]: {message}");
                sw.WriteLine("---------------------------------");
            }

            bool errorCountFileExists = File.Exists(_errorCountPath);
            int errorCount=1;
            if (!errorCountFileExists)
            {
                File.Create(_errorCountPath);

                using (StreamWriter sw = new StreamWriter(_errorCountPath))
                {
                    sw.WriteLine(errorCount);
                }
            }
            else
            {
                using (StreamReader sr = new StreamReader(_errorCountPath))
                {
                    int.TryParse(sr.ReadLine(), out errorCount);
                }
                using (StreamWriter sew = new StreamWriter(_errorCountPath, false))
                {
                    sew.WriteLine(errorCount + 1);
                }
            }


        }
    }
}
