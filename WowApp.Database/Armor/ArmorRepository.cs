using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WowApp.Model.Error;

namespace WowApp.Database.Armor
{
    public class ArmorRepository : AbstractRepository<ArmorModel>, IArmorRepository
    {
        public ArmorRepository(PostgreSqlContext context, ILoggerFactory loggerFactory) : base(context, loggerFactory)
        {

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
    }
}