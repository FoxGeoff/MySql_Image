using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MySql_Image
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(SetupConfiguration)
                .UseStartup<Startup>()
                .Build();

        private static void SetupConfiguration(WebHostBuilderContext context, IConfigurationBuilder builder)
        {
            /* Uncomment these two lines for connection string from config.json (not a sercure configuraion) */
            builder.Sources.Clear();
            builder.AddJsonFile("config.json", false, true);
            builder.AddUserSecrets("3ce4f055-2547-4b62-a51e-5c49dd0e20a3");
        }
    }
}
