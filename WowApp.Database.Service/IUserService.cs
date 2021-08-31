using System.Threading.Tasks;
using WowApp.Database.User;
using WowApp.Model.User;

namespace WowApp.Database.Service
{
    public interface IUserService
    {
        Task<UserModel> Create(
            string firstName,
            string lastName,
            string cover,
            UserRole role
        );


        Task<IUser> GetOne(int id);


        string GetTitleMessage();
    }
}