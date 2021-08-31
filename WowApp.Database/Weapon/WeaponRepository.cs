using Microsoft.Extensions.Logging;
using WowApp.Model.Weapon;

namespace WowApp.Database.Weapon
{
    public class WeaponRepository : AbstractRepository<WeaponModel>, IWeaponRepository
    {
        public WeaponRepository(PostgreSqlContext context, ILoggerFactory loggerFactory) : base(context, loggerFactory)
        {
        }


        public WeaponModel Create(
            string name,
            int damage,
            float reloadTime,
            WeaponType type,
            float range
        )
        {
            var model = WeaponModel.CreateModel(name, damage, reloadTime, type);
            return model;
        }
    }
}