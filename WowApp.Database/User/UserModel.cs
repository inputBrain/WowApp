using WowApp.Model.User;

namespace WowApp.Database.User
{
    public class UserModel : AbstractModel, IUserModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Cover { get; set; }

        public UserRole Role { get; set; }


        public static UserModel CreateModel
        (
            string firstName,
            string lastName,
            string cover,
            UserRole role
        )

        {
            return new UserModel()
            {
                FirstName = firstName,
                LastName = lastName,
                Cover = cover,
                Role = role
            };
        }
    }
}