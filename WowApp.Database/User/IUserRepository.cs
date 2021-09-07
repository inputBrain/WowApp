using System.Threading.Tasks;
using WowApp.Model.User;

namespace WowApp.Database.User
{
    public interface IUserRepository
    {
        Task<UserModel> GetOne(int id);


        Task<UserModel> GetFull(int id);

    }
}