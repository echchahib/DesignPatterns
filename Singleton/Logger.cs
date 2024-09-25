using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Logger
    {
        private static Logger logger;

        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;


        private Logger() { }

        public static Logger GetInstance()
        {
            if(logger == null)
                logger = new Logger();

            return logger;
        }

        public void Log(LogType logType,string message) 
        {
            string relativeDirectory = Path.Combine(baseDirectory, "FilesLog");
            string filePath = Path.Combine(relativeDirectory, "Log.txt");
            string content = "";


            if (!Directory.Exists(relativeDirectory))
            {
                Directory.CreateDirectory(relativeDirectory);
            }

            
            switch (logType)
            {
                case LogType.Error:
                    content = DateTime.Now.ToString() + " - Error : " + message + Environment.NewLine;
                    break;

                case LogType.Warning:
                    content = DateTime.Now.ToString() + " - Warning : " + message + Environment.NewLine;
                    break;

                case LogType.Info:
                    content = DateTime.Now.ToString() + " - Info : " + message + Environment.NewLine;
                    break;

                default: 
                    content = DateTime.Now.ToString() + " - Empty : " + message + Environment.NewLine;
                    break;
            }
            
            File.AppendAllText(filePath, content);
        }
    }

    public enum LogType
    {
        Error = 0,
        Warning = 1,
        Info = 2,
    }
}
