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


        public async Task<ArmorModel> Create(string title, string cover, int requiredLevel, int pDef, int mDef, float enhanceLevel, float weight, float buyPrice, float salePrice, ArmorType type, ArmorGrade grade)
        {
            var model = ArmorModel.CreateModel(title, cover, requiredLevel, pDef, mDef, enhanceLevel, weight, buyPrice, salePrice, type, grade);

            var result = await CreateModelAsync(model);
            if (result is null)
            {
                throw new ErrorException(Error.DbError("Armor not created"));
            }

            return model;
        }

        public async Task<ArmorModel> GetOne(int id)
        {
            var model = await FindOne(id);
            if (model is null)
            {
                throw new ErrorException(Error.DbError("Armor not found"));
            }
            return model;
        }

        public async Task<ArmorModel> GetTitle(int id)
        {
            var model = await FindOne(id);
            if (model is null)
            {
                throw new ErrorException(Error.DbError("Armor not found"));
            }

            return model;
        }
    }
}