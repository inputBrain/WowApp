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
            // var model = _armorRepository.Create(
            //     "Title",
            //     5.53F,
            //     8.8F,
            //     10.0F,
            //     ArmorType.Footwear
            // ).Result;


            // Assert.Equal("Title", model.Title);
        }
    }
}