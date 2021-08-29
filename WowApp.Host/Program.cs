using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using WowApp.Database.User;
using WowApp.Database.Weapon;
using WowApp.Database.Weapon.Explosives;
using WowApp.Model.User;

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
                Damage = 1,
                Type = Model.Weapon.WeaponType.firearms,
            };

            var secondTestWeapon = new ExplosiveModel()
            {
                Name = "C4",
                ReloadTime = 0f,
                Damage = 200,
                Type = Model.Weapon.WeaponType.explosives,
                Range = 30f
            };

            Console.WriteLine
            (
                $"Название {testWeapon.Name}," +
                $" урон {testWeapon.Damage}," +
                $" время перезарядки {testWeapon.ReloadTime}," +
                $" тип {testWeapon.Type}"
            );

            Console.WriteLine
            (
                $"Название {secondTestWeapon.Name}," +
                $" урон {secondTestWeapon.Damage}," +
                $" время перезарядки {secondTestWeapon.ReloadTime}," +
                $" тип {secondTestWeapon.Type}",
                $" радиус {secondTestWeapon.Range}"
            );








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