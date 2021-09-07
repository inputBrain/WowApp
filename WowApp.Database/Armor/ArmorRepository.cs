
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WowApp.Model.Armor;
using WowApp.Model.Error;

namespace WowApp.Database.Armor
{
    public class ArmorRepository : AbstractRepository<ArmorModel>, IArmorRepository
    {
        public ArmorRepository(PostgreSqlContext context, ILoggerFactory loggerFactory) : base(context, loggerFactory)
        {

        }

        public async Task<ArmorModel> Create(
            string title,
            float defence,
            float weight,
            float temperatureProtection,
            ArmorType type
        )
        {
            var model = ArmorModel.CreateModel(title, defence, weight, temperatureProtection, type);

            var result = await CreateModelAsync(model);
            if (result == null)
            {
                throw new ErrorException(Error.DbError("Armor not created"));
            }

            return model;
        }


        public async Task<ArmorModel> GetOne(int id)
        {
            var model = await FindOne(id);
            if (model == null)
            {
                throw new ErrorException(Error.DbError("Armor not found"));
            }
            return model;
        }

        public async Task<ArmorModel> GetTitle(int id)
        {
            var model = await FindOne(id);
            if (model == null)
            {
                throw new ErrorException(Error.DbError("Armor not found"));
            }
            return model;
        }
    }
}