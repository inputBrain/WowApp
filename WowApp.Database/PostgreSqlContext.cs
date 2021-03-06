using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WowApp.Database.Armor;
using WowApp.Database.User;
using WowApp.Database.Weapon;

namespace WowApp.Database
{
    public class PostgreSqlContext : DbContext
    {
        public readonly IDatabaseContainer Db;

        public DbSet<UserModel> User { get; set; }

        public DbSet<ArmorModel> Armor { get; set; }

        public DbSet<WeaponModel> Weapon { get; set; }


        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options, ILoggerFactory loggerFactory) : base(options)
        {
            Db = new DatabaseContainer
            (
                new UserRepository(this, loggerFactory),
                new ArmorRepository(this, loggerFactory),
                new WeaponRepository(this, loggerFactory)
            );
        }
    }
}