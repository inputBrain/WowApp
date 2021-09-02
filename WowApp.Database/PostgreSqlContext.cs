using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WowApp.Database.Explosive;
using WowApp.Database.Inventory;
using WowApp.Database.User;
using WowApp.Database.Weapon;

namespace WowApp.Database
{
    public class PostgreSqlContext : DbContext
    {
        public readonly IDatabaseContainer Db;

        public DbSet<UserModel> User { get; set; }

        public DbSet<WeaponModel> Weapon { get; set; }

        public DbSet<ExplosiveModel> Explosive { get; set; }

        public DbSet<InventoryModel> Inventory { get; set; }


        public PostgreSqlContext(
            DbContextOptions<PostgreSqlContext> options,
            ILoggerFactory loggerFactory
        ) : base(options)
        {
            Db = new DatabaseContainer(
                new UserRepository(this, loggerFactory),
                new WeaponRepository(this, loggerFactory)
            );
        }


        //TODO:
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
            // modelBuilder.Entity<WeaponModel>()
                        // .HasOne(x => x.Explosive)
                        // .WithMany(x => x.)
        // }
    }
}