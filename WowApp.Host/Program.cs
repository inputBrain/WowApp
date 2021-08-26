using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using WowApp.Host.Models.Weapons;

namespace WowApp.Host
{
    public class Program
    {
        private static IWeaponContainer WeaponContainer;

        public Program(IWeaponContainer weaponContainer)
        {
            WeaponContainer = weaponContainer;
        }


        public static string GetAxeInfo() //TODO: Need to implement Dependency Injection...
        {
            var axeModel = WeaponContainer.Axe.CreateAxe("Color green!");
            var info = WeaponContainer.Axe.GetInfo(axeModel, true);

            return info;
        }


        public static void Main(string[] args)
        {
            var webHost = BuildWebHost(args);

            GetAxeInfo();
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
    }
}