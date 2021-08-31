using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WowApp.Model.User;

namespace WowApp.Database.User
{
    public class UserRepository : AbstractRepository<UserModel>, IUserRepository
    {
        public UserRepository(PostgreSqlContext context, ILoggerFactory loggerFactory) : base(context, loggerFactory)
        {
            //��� �������� ��� - �� ������������
        }


        public async Task<UserModel> Create( //��������� ������ ��� �������� ����� ��������(
            string firstName,
            string lastName,
            string cover,
            UserRole role
        )

        {
            var model = UserModel.CreateModel(firstName, lastName, cover, role);//���������� ������ � UserModel

            var result = await CreateModelAsync(model);
            if (result == null)
            {

            }
            return model;
        }
    }
}