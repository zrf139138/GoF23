using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Singleton
{
    public class Logger
    {
        private StreamWriter fs;
        private static Logger instance;
        private static object obj = new object();

        private Logger()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "log\\log.txt");
            fs = new StreamWriter(path, true);            
        }
        public static Logger GetLogger()
        {
            if (instance == null)
            {
                lock(obj)
                {
                    if(instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
           return instance;
        }

        public void Log(string message)
        {
            fs.Write(message);
            fs.Flush();
        }
    }
}
