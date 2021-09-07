using Microsoft.Extensions.Logging;
using WowApp.Database.Armor;
using WowApp.Database.Inventory;
using WowApp.Database.User;
using WowApp.Database.Weapon;

namespace WowApp.Database
{
    public class Factory
    {
        public static IDatabaseContainer Create(PostgreSqlContext db, ILoggerFactory loggerFactory)
        {
            return new DatabaseContainer(
                new UserRepository(db, loggerFactory),
                new ArmorRepository(db, loggerFactory),
                new WeaponRepository(db, loggerFactory)
            );
        }
    }
}