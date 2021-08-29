using Microsoft.Extensions.Logging;
using WowApp.Database.User;
using WowApp.Database.Weapon;

namespace WowApp.Database
{
    public class Factory
    {
        public static IDatabaseContainer Create(ILoggerFactory loggerFactory)
        {
            return new DatabaseContainer(
                new UserRepository(loggerFactory),
                new WeaponRepository(loggerFactory)
            );
        }
    }
}