using Baza;
using Entity.Interfesji;
using Entity.Entiteti;
using Entity.Servisi;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace Dizajn
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var host = CreateHostBuilder();

            ApplicationConfiguration.Initialize();
            Application.Run(host.Services.GetRequiredService<KartaForma>());
            await host.RunAsync();
        }

        private static IHost CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices(servisi =>
                {
                    servisi.AddTransient<KartaServis>();
                    servisi.AddScoped<IZeleznickaStanicaDbContext, ZeleznickaStanicaDbContext>();
                    servisi.AddScoped<IServiceProvider, ServiceProvider>();
                    servisi.AddScoped<KartaForma>();
                    
                })
                .Build();
        }
    }
}