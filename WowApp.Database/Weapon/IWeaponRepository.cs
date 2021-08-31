using WowApp.Model.Weapon;

namespace WowApp.Database.Weapon
{
    public interface IWeaponRepository
    {
        WeaponModel Create(
            string name,
            int damage,
            float reloadTime,
            WeaponType type,
            float range
        );
    }
}