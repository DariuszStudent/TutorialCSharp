using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class ConsoleLogger : ILogger
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Verbose;

        public void LogMessage(string message, LogLevel logLevel = LogLevel.Debug)
        {
            if (LogLevel > LogLevel)
                return;

            Console.WriteLine(message);
        }
    }
}
