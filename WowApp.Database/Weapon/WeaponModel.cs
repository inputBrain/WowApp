using WowApp.Model.Weapon;

namespace WowApp.Database.Weapon
{
    public class WeaponModel : AbstractModel, IWeapon
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public float ReloadTime { get; set; }

        public WeaponType Type { get; set; }


        public static WeaponModel CreateModel(
            string name,
            int damage,
            float reloadTime,
            WeaponType type
        )

        {
            return new WeaponModel()
            {
                Name = name,
                Damage = damage,
                ReloadTime = reloadTime,
                Type = type
            };
        }
    }
}