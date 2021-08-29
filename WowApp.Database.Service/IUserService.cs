using WowApp.Database.User;
using WowApp.Model.User;

namespace WowApp.Database.Service
{
    public interface IUserService
    {
        UserModel Create(
            string firstName,
            string lastName,
            string cover,
            UserRole role
        );


        string GetTitleMessage();
    }
}