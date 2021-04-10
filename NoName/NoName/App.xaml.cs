using Microsoft.Extensions.DependencyInjection;
using NoName.Database;
using NoName.Services;
using NoNameApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NoName
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var serviceColletion = new ServiceCollection();

            serviceColletion.AddTransient<IDataStoreManager, DataStoreManager>();
            serviceColletion.AddTransient<ICalculatorManager, CalculatorManager>();
        }
    }
}
