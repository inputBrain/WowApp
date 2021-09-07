using System.Threading.Tasks;
using WowApp.Database.User;
using WowApp.Model.User;

namespace WowApp.Database.Service
{
    public interface IUserService
    {
        Task<UserModel> Create(
            string nickname,
            float hp,
            uint level,
            float experience
        );


        Task<IUser> GetOne(int id);

        Task<UserModel> GetFull(int id);

        string GetTitleMessage();
    }
}