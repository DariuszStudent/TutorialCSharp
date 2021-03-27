namespace Interface
{
    public interface ILogger
    {
        LogLevel LogLevel { get; set; }

        void LogMessage(string message, LogLevel logLevel = LogLevel.Debug);
    }
}
