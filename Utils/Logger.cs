using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public enum LogLevel
    {
        Info,
        Warning,
        Error
    }

    public class Logger<T>
    {
        private string logDirectory;
        private string fileName;
        private string fileExtension;

        private string logFormat;

        public Logger()
        {
            fileName = ConfigurationManager.AppSettings["LogFileName"];
            fileExtension = ConfigurationManager.AppSettings["LogFileExtension"];
            logDirectory = ConfigurationManager.AppSettings["LogDirectory"];

            Directory.CreateDirectory(logDirectory);

     
            logFormat = $"{{0}} - {{1}} - {{2}} - {{3}}-{{4}}";
        }


        public void Log(LogLevel level, string message)
        {
            string clasName = typeof(T).Name;
            string methodName = new StackTrace().GetFrame(1).GetMethod().Name;
            
            string logMessage = string.Format(logFormat,DateTime.Now,clasName,methodName, level.ToString(), message);

            fileName = fileName +  DateTime.Now.ToString("yyyyMMdd") +fileExtension;


            string logFilePath = Path.Combine(logDirectory, fileName);


            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(logMessage);
            }
        }
    }
}
