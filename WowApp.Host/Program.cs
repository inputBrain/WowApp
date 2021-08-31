using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WowApp.Database;

namespace WowApp.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webHost = BuildWebHost(args);
            var commandLineApplication = new CommandLineApplication(false);


            var doMigrate = commandLineApplication.Option
            (
                "--ef-migrate",
                "Apply entity framework migrations and exit",
                CommandOptionType.NoValue
            );
            var verifyMigrate = commandLineApplication.Option
            (
                "--ef-migrate-check",
                "Check the status of entity framework migrations",
                CommandOptionType.NoValue
            );
            var run = commandLineApplication.Option
            (
                "--run",
                "Run Api Server",
                CommandOptionType.NoValue
            );

            commandLineApplication.HelpOption("-? | -h | -help");

            commandLineApplication.OnExecute
            (
                () =>
                {
                    ExecuteApp(webHost, doMigrate, verifyMigrate, run);
                    return 0;
                }
            );

            commandLineApplication.Execute(args);


        }


        private static IWebHost ExecuteApp
        (
            IWebHost webHost,
            CommandOption doMigrate,
            CommandOption verifyMigrate,
            CommandOption run
        )
        {
            if (run.HasValue())
            {
                InitWebServices(webHost).GetAwaiter().GetResult();
                return webHost;
            }

            if (verifyMigrate.HasValue() && doMigrate.HasValue())
            {
                Console.WriteLine("ef-migrate and ef-migrate-check are mutually exclusive, select one, and try again");
                Environment.Exit(2);
            }

            var serviceScopeFactory = (IServiceScopeFactory)webHost.Services.GetService(typeof(IServiceScopeFactory));

            using (var scope = serviceScopeFactory.CreateScope())
            {
                var services = scope.ServiceProvider;
                using (var context = services.GetRequiredService<PostgreSqlContext>())
                {
                    if (verifyMigrate.HasValue())
                    {
                        Console.WriteLine("Validating status of Entity Framework migrations");
                        _verifyMigration(context);
                        Environment.Exit(3);
                    }

                    if (doMigrate.HasValue())
                    {
                        Console.WriteLine("Applying Entity Framework migrations");
                        context.Database.Migrate();
                        Console.WriteLine("All done, closing app");
                        Environment.Exit(0);
                    }
                }
            }

            InitWebServices(webHost).GetAwaiter().GetResult();
            return webHost;
        }


        public static IWebHost BuildWebHost(string[] args)
        {
            var config = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile("appsettings.json", optional: true)
                         .Build();

            return WebHost.CreateDefaultBuilder(args)
                          .UseStartup<Startup>()
                          .UseUrls(config.GetSection("Url").Value)
                          .Build();
        }


        private static void _verifyMigration(PostgreSqlContext context)
        {
            var pendingMigration = context.Database.GetPendingMigrations();
            var migrations = pendingMigration as IList<string> ?? pendingMigration.ToList();

            if (!migrations.Any())
            {
                Console.WriteLine("No pending migrations.");
                Environment.Exit(0);
            }

            Console.WriteLine("Pending migrations {0}", migrations.Count);

            foreach (var migration in migrations)
            {
                Console.WriteLine($"\t {migration} ");
            }
        }


        private static async Task<int> InitWebServices(IWebHost webHost)
        {
            await Task.WhenAll
            (
                webHost.RunAsync()
            );


            await Task.WhenAll
            (
                webHost.StopAsync()
            );
            Environment.Exit(0);
            return 0;
        }
    }
}