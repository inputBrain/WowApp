using System.Threading.Tasks;
using WowApp.Database.User;
using WowApp.Model.User;

namespace WowApp.Database.Service
{
    public interface IUserService
    {
        Task<IUser> GetOne(int id);

        Task<UserModel> GetFull(int id);
    }
}