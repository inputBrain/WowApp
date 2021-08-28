using Microsoft.Extensions.Logging;
using WowApp.Model.Models.User;

namespace WowApp.Database.User
{
    public class UserRepository : AbstractRepository<UserModel>, IUserRepository
    {
        public UserRepository(ILoggerFactory loggerFactory) : base(loggerFactory)
        {
        }

        public UserModel Create(
            string firstName,
            string lastName,
            string cover,
            UserRole role
        )
        {
            var model = UserModel.CreateModel(firstName, lastName, cover, role);

            return model;
        }
    }
}