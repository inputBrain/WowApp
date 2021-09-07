using System.Threading.Tasks;
using WowApp.Model.User;

namespace WowApp.Database.User
{
    public interface IUserRepository
    {
        Task<UserModel> Create(
            string nickname,
            float hp,
            uint level,
            float experience
        );


        Task<UserModel> GetOne(int id);


        Task<UserModel> GetFull(int id);

    }
}