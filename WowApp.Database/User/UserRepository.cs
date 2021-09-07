using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WowApp.Model.Error;

namespace WowApp.Database.User
{
    public class UserRepository : AbstractRepository<UserModel>, IUserRepository
    {
        public UserRepository(PostgreSqlContext context, ILoggerFactory loggerFactory) : base(context, loggerFactory)
        {
        }


        public async Task<UserModel> GetOne(int id)
        {
            var model = await FindOne(id);
            if (model == null)
            {
                throw new ErrorException(Error.DbError("User not found"));
            }

            return model;
        }



        //TODO:
        public async Task<UserModel> GetFull(int id)
        {

            var model = await DbModel
                              // .Include(x => x.Inventory)
                              .FirstOrDefaultAsync(x => x.Id == id);

            if (model == null)
            {
                throw new ErrorException(Error.DbError("User not found"));
            }

            return model;
        }
    }
}