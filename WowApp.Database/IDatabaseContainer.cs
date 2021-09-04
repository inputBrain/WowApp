using WowApp.Database.Armor;
using WowApp.Database.Inventory;
using WowApp.Database.User;
using WowApp.Database.Weapon;

namespace WowApp.Database
{
    public interface IDatabaseContainer
    {
        IUserRepository User { get; }
        IWeaponRepository Weapon { get; }
        IArmorRepository Armor { get; }

        IInventoryRepository Inventory { get; }
    }
}