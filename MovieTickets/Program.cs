using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Identity;

namespace MovieTickets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
        #region Azure Key Vault
.ConfigureAppConfiguration((context, config) =>
{
    var keyVaultEndpoint = new Uri(Environment.GetEnvironmentVariable("VaultUri"));
    config.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());
})
        #endregion
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
