using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternApp
{
    class Logger
    {
        private LogLevel logLevel;
        private static Logger instance;
        private static readonly object _sync = new object();

        private Logger()
        {
            logLevel = LogLevel.DEBUG;
        }

        public void LogDebug(string message)
        {
            if(logLevel<=LogLevel.DEBUG)
            Console.WriteLine("DEBUG: " + message);
        }

        public void LogInformation(string message)
        {
            if(logLevel<=LogLevel.INFO)
            Console.WriteLine("INFO: " + message);
        }
        public void LogWarning(string message)
        {
            if(logLevel<=LogLevel.WARN)
            Console.WriteLine("WARN: " + message);
        }

       

        public void LogError(string message)
        {
            if(logLevel<=LogLevel.ERROR)
            Console.WriteLine("ERROR: " + message);
        }

        public void setLogLevel(LogLevel logLevel)
        {
            this.logLevel = logLevel;
        }

        public static Logger getInstance()
        {
            lock (_sync) // Thread safe 
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
            }

            return instance;
        }
    }
}
