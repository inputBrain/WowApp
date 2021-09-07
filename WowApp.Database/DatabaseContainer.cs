using WowApp.Database.Armor;
using WowApp.Database.Inventory;
using WowApp.Database.User;
using WowApp.Database.Weapon;

namespace WowApp.Database
{
    public class DatabaseContainer : IDatabaseContainer
    {
        public IUserRepository User { get; }
        public IArmorRepository Armor { get; }
        public IWeaponRepository Weapon { get; }


        public DatabaseContainer(
            IUserRepository user,
            IArmorRepository armor,
            IWeaponRepository weapon
        )
        {
            User = user;
            Armor = armor;
            Weapon = weapon;
        }
    }
}