using WowApp.Host.Models.Weapons.Axe;
using WowApp.Host.Models.Weapons.Knife;

namespace WowApp.Host.Models.Weapons
{
    public class WeaponContainer : IWeaponContainer
    {
        public IAxe Axe { get; }
        public IKnife Knife { get; }


        public WeaponContainer(
            IAxe axe,
            IKnife knife
        )
        {
            Axe = axe;
            Knife = knife;
        }
    }
}