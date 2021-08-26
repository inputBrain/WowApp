using WowApp.Host.Models.Weapons.Axe;
using WowApp.Host.Models.Weapons.Knife;

namespace WowApp.Host.Models.Weapons
{
    public interface IWeaponContainer
    {
        IAxe Axe { get; }

        IKnife Knife { get; }
    }
}