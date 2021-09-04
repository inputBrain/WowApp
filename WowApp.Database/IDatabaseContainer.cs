using WowApp.Database.Clothing;
using WowApp.Database.User;
using WowApp.Database.Weapon;

namespace WowApp.Database
{
    public interface IDatabaseContainer
    {
        IUserRepository User { get; }
        IWeaponRepository Weapon { get; }
        IClothingRepository Clothing { get; }
    }
}