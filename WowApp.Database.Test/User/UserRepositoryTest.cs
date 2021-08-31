using WowApp.Database.User;
using WowApp.Model.User;
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
            var model = _userRepository.Create("First name", "Last name", "Cover", UserRole.Admin).Result;
            Assert.Equal("First name", model.FirstName);
        }
    }
}