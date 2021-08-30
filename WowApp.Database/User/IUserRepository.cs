using WowApp.Model.User;

namespace WowApp.Database.User
{
    public interface IUserRepository//Абстрактное описание User'a
    {
        UserModel Create
            (
            string firstName,
            string lastName,
            string cover,
            UserRole role
        );

    }
}