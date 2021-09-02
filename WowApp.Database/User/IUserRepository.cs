using System.Threading.Tasks;
using WowApp.Model.User;

namespace WowApp.Database.User
{
    public interface IUserRepository//����������� �������� User'a
    {
        Task<UserModel> Create(
            string firstName,
            string lastName,
            string cover,
            UserRole role
        );


        Task<UserModel> GetOne(int id);

    }
}