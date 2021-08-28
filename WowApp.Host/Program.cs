using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using WowApp.Database.User;
using WowApp.Database.Weapon;
using WowApp.Model.Models.User;

namespace WowApp.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var userModel = new UserModel()
            {
                Id = 1,
                FirstName = "Hello",
                LastName = "World",
                Cover = "Cover",
                Role = UserRole.Admin
            };
            var testWeapon = new WeaponModel()
            {
                Name = "Автомат",
                ReloadTime = 3.23f,
            };

            Console.WriteLine(testWeapon.Name + " " + testWeapon.ReloadTime);

            Console.WriteLine(userModel.FirstName);


            var webHost = BuildWebHost(args);
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