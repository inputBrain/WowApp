using WowApp.Database.User;
using WowApp.Database.Weapon;

namespace WowApp.Database
{
    public class DatabaseContainer : IDatabaseContainer
    {
        public IUserRepository User { get; }
        public IWeaponRepository Weapon { get; }


        public DatabaseContainer(
            IUserRepository user,
            IWeaponRepository weapon
        )
        {
            User = user;
            Weapon = weapon;
        }
    }
}