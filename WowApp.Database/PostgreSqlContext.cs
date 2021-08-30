using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WowApp.Database.User;
using WowApp.Database.Weapon;

namespace WowApp.Database
{
    public class PostgreSqlContext : DbContext
    {
        public readonly IDatabaseContainer Db;

        public DbSet<UserModel> User { get; set; }


        public PostgreSqlContext(
            DbContextOptions<PostgreSqlContext> options,
            ILoggerFactory loggerFactory
        ) : base(options)
        {
            Db = new DatabaseContainer(
                new UserRepository(loggerFactory),
                new WeaponRepository(loggerFactory)
            );
        }
    }
}