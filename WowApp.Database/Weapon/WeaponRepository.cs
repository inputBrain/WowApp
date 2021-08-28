using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace WowApp.Database.Weapon
{
    public class WeaponRepository : AbstractRepository<WeaponModel>, IWeaponRepository
    {
        public WeaponRepository(ILoggerFactory loggerFactory) : base(loggerFactory)
        {
        }
        public WeaponModel Create
        (
            string name,
            int damage,
            float reloadTime
        )
        {
            var model = WeaponModel.CreateModel(name, damage, reloadTime);
            return model;
        }
    }
}
