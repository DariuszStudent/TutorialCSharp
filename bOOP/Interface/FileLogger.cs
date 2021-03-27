using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Interface
{
    public class FileLogger : ILogger, IAnotherInterface
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Critical;

        public void LogMessage(string message, LogLevel logLevel = LogLevel.Debug)
        {
            if (LogLevel > LogLevel)
                return;

            File.WriteAllText("log.txt", message);
        }
    }
}
