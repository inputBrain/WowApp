using System;
using System.Collections.Generic;
using System.Text;


using WowApp.Model.Models.Weapon;

namespace WowApp.Database.Weapon
{
    public class WeaponModel : AbstractModel, IWeapon
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public float ReloadTime { get; set; }

        public static WeaponModel CreateModel
        (
            string name,
            int damage,
            float reloadTime
        )
        {
            return new WeaponModel()
            {
                Name = name,
                Damage = damage,
                ReloadTime = reloadTime
            };

        }


    }
}
