using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exellent_Taste.DAL;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Exellent_Taste.WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ExellentDbContext>();
                    Seed.Initialize(context);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while seeding the database.");
                }
            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) => 
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
    }
}
