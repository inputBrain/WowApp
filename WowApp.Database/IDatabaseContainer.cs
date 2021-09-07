using WowApp.Database.Armor;
using WowApp.Database.Inventory;
using WowApp.Database.User;
using WowApp.Database.Weapon;

namespace WowApp.Database
{
    public interface IDatabaseContainer
    {
        IUserRepository User { get; }
        IArmorRepository Armor { get; }
        IWeaponRepository Weapon { get; }
    }
}