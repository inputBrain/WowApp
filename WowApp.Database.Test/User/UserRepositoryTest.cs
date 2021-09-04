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

            Assert.Equal(0, model.Inventory.Money);

            var getFullUser = _userRepository.GetFull(model.Id).Result;
            Assert.NotNull(getFullUser);


            Assert.Equal(getFullUser.FirstName, model.FirstName);
            Assert.Equal(getFullUser.Inventory, model.Inventory);
            Assert.Equal(getFullUser.Inventory.MaxSize, model.Inventory.MaxSize);

        }
    }
}