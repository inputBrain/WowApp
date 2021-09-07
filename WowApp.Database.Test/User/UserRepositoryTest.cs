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
            var model = _userRepository.Create("Nickname", 3f, 0, 0).Result;
            Assert.Equal("Nickname", model.Nickname);//pass

            Assert.Equal(0, model.Inventory.Money);//pass
            

            var getFullUser = _userRepository.GetFull(model.Id).Result;
            Assert.NotNull(getFullUser);


            Assert.Equal(getFullUser.Nickname, model.Nickname);
            Assert.Equal(getFullUser.Inventory, model.Inventory);
            Assert.Equal(getFullUser.Inventory.MaxSize, model.Inventory.MaxSize);

        }
    }
}