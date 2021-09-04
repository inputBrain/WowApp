using Microsoft.Extensions.Logging;
using WowApp.Model.Weapon;
using System;
using System.Threading.Tasks;
using WowApp.Model.Error;

namespace WowApp.Database.Weapon
{
    public class WeaponRepository : AbstractRepository<WeaponModel>, IWeaponRepository
    {
        public WeaponRepository(PostgreSqlContext context, ILoggerFactory loggerFactory) : base(context, loggerFactory)
        {

        }

        public WeaponModel Create
        (
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


        public async Task<WeaponModel> GetOne(int id)
        {
            var model = await FindOne(id);
            if (model == null)
            {
                throw new ErrorException(Error.DbError("Weapon not found"));
            }

            return model;


        }
    }
}
