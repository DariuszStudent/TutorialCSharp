using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DepedencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = (IServiceCollection)new ServiceCollection();

            serviceCollection.AddTransient<ILogger, FileLogger>();

            /*var configurationBuilder = new ConfigurationBuilder();

            configurationBuilder.AddJsonFile("appsettings.json", true);

            var configuration = configurationBuilder.Build();

            serviceCollection.AddSingleton<IConfiguration>(configuration);*/

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var logger = serviceProvider.GetServices<ILogger>();
        }
    }

    public interface ILogger
    {
        int SomeValue { get; set; }

        void Add();
    }

    public class FileLogger : ILogger
    {
        public int SomeValue { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }

    public class ConsoleLogger : ILogger
    {
        public int SomeValue { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }
}
