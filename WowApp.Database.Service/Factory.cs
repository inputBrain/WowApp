using Microsoft.Extensions.Logging;

namespace WowApp.Database.Service
{
    public class Factory
    {
        public static IServiceContainer Create(
            ILoggerFactory loggerFactory,
            IDatabaseContainer databaseContainer
        )
        {
            return new ServiceContainer(
                new UserService(loggerFactory.CreateLogger<UserService>(), databaseContainer.User),
                new ArmorService(databaseContainer.Armor),
                new WeaponService(databaseContainer.Weapon)
            );
        }
    }
}