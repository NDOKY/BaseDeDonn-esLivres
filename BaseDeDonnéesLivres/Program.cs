using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseDeDonnéesLivres.Data;
using BaseDeDonnéesLivres.Models;
using Microsoft.Extensions.DependencyInjection;


namespace BaseDeDonnéesLivres
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var sercices = scope.ServiceProvider;

                try
                {
                    SeddData.Initialize(sercices);
                }
                catch (Exception ex)
                {
                    var logger = sercices.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Une erreur est survenu lors de la mise en place de la DB");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
