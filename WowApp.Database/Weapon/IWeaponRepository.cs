using System;
using System.Collections.Generic;
using System.Text;

namespace WowApp.Database.Weapon
{
    public interface IWeaponRepository
    {
        WeaponModel Create
        (
            string name,
            int damage,
            float reloadTime
        );
    }
}
