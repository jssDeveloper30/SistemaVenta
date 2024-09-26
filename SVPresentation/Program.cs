using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SVPresentation.Formularios;
using SVRepository;
using SVServices;

namespace SVPresentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            var formService = host.Services.GetRequiredService<FrmProducto>();
            Application.Run(formService);
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.RegisterRepositoryDependencies();
                services.RegisterServicesDependencies();

                services.AddTransient<FrmCategoria>();
                services.AddTransient<FrmProducto>();
            });
    }
}