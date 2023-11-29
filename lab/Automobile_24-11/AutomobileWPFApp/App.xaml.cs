using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AutomobileLibrary.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AutomobileWPFApp {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private ServiceProvider serviceProvider;
        public App() {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        public void ConfigureServices(ServiceCollection services) {
            services.AddSingleton(typeof(ICarRepository), typeof(CarRepository));
            services.AddSingleton<WindowCarManagement>();
        }

        public void OnStartUp(object sender, StartupEventArgs e) {
            var windowcarManagement = serviceProvider.GetService<WindowCarManagement>();
            windowcarManagement.Show();
        }
    }
}
