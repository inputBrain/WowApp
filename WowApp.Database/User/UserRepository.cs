using Microsoft.Extensions.Logging;
using WowApp.Model.User;

namespace WowApp.Database.User
{
    public class UserRepository : AbstractRepository<UserModel>, IUserRepository
    {
        public UserRepository(ILoggerFactory loggerFactory) : base(loggerFactory)
        {
            //Тут творится что - то неизведанное
        }

        public UserModel Create//Принимает данные для создания новой модельки
            (
            string firstName,
            string lastName,
            string cover,
            UserRole role
        )

        {
            var model = UserModel.CreateModel(firstName, lastName, cover, role);//Отправляем данные в UserModel

            return model;
        }
    }
}