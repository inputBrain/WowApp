using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WowApp.Model.Clothing;

namespace WowApp.Database.Clothing
{
    public class ClothingRepository : AbstractRepository<ClothingModel>, IClothingRepository
    {
        public ClothingRepository(PostgreSqlContext context, ILoggerFactory loggerFactory) : base(context, loggerFactory)
        {
            
        }

        public async Task<ClothingModel> Create(
            int id,
            string title,
            float defence,
            float weight,
            float temperatureProtection,
            ClothingType type
        )
        {
            var model = ClothingModel.CreateModel(id, title, defence, weight, temperatureProtection, type); 

            var result = await CreateModelAsync(model);
            if (result == null)
            {
            }

            return model;
        }
    }
}