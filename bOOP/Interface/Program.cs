using System;

namespace Interface
{
    class Program
    {
        public static ILogger GetLogger()
        {
            return new ConsoleLogger();    // wystarczy tutaj zmienić na ConsoleLogger i już zmienia wszystko :)
        }

        static void Main(string[] args)
        {
            // .....

            var logger = GetLogger();

            logger.LogMessage("wiadomość");
            logger.LogMessage("wiadomość KRYTYCZNA!!!!!!!!!!!!", LogLevel.Critical);


        }
    }
}
