using WowApp.Database.Armor;
using WowApp.Model.Armor;
using Xunit;

namespace WowApp.Database.Test.Armor
{
    public class ArmorRepositoryTest : DbTestCase
    {
        private readonly IArmorRepository _armorRepository;


        public ArmorRepositoryTest()
        {
            _armorRepository = DatabaseContainer.Armor;
        }

        [Fact]
        public void CreateModelTest()
        {
            var model = _armorRepository.Create(
                "Title",
                "Cover",
                0,
                0,
                0,
                0,
                1f,
                0,
                0,
                0,
                0
            ).Result;


            Assert.Equal("Title", model.Title);
        }
    }
}