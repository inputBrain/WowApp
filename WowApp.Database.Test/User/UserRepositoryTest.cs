using WowApp.Database.User;
using Xunit;

namespace WowApp.Database.Test.User
{
    public class UserRepositoryTest : DbTestCase
    {
        private readonly IUserRepository _userRepository;


        public UserRepositoryTest()
        {
            _userRepository = DatabaseContainer.User;
        }


        [Fact]
        public void CreateUser()
        {

        }
    }
}