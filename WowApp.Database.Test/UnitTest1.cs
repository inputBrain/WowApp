using System;
using WowApp.Database.User;
using WowApp.Model.User;
using Xunit;

namespace WowApp.Database.Test
{
    public class UnitTest1 : DbTestCase
    {
        private readonly IUserRepository _userRepository;


        public UnitTest1(IDatabaseContainer databaseContainer)
        {
            _userRepository = databaseContainer.User;
        }


        [Fact]
        public void Test1()
        {
            var model = _userRepository.Create("First name", "Last name", "Cover", UserRole.Admin);
            Assert.Equal("First name", model.FirstName);
        }
    }
}