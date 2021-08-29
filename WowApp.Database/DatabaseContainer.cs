using Microsoft.Extensions.Logging;
using WowApp.Database.User;
using WowApp.Database.Weapon;

namespace WowApp.Database
{
    // Этот класс нужен для для создания объектов на глобальном уровне?
    public class DatabaseContainer : IDatabaseContainer
    {
        public IUserRepository User { get; }
        public IWeaponRepository Weapon { get; }


        public DatabaseContainer(ILoggerFactory loggerFactory)
        {
            User = new UserRepository(loggerFactory);
        }
    }
}