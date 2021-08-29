using WowApp.Model.Weapon;
using WowApp.Model.Weapon.Explosives;

namespace WowApp.Database.Weapon.Explosives
{
    public class ExplosiveModel : WeaponModel, IExplosive
    {
        public float Range { get; set; }

        public static ExplosiveModel CreateModel
       (
           string name,
           int damage,
           float reloadTime,
           float range,
           WeaponType type
       )
        {
            return new ExplosiveModel()
            {
                Name = name,
                Damage = damage,
                ReloadTime = reloadTime,
                Range = range,
                Type = type
            };

        }
    }
}
