using WowApp.Host.Models.Weapons.Axe;
using WowApp.Host.Models.Weapons.Knife;

namespace WowApp.Host.Models.Weapons
{
    public static class Factory
    {
        public static IWeaponContainer Create()
        {
            return new WeaponContainer(
                new AxeModel(),
                new KnifeModel()
            );
        }
    }
}