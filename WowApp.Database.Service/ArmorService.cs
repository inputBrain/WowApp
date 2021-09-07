using System.Threading.Tasks;
using WowApp.Database.Armor;

namespace WowApp.Database.Service
{
    public class ArmorService: IArmorService
    {
        private readonly IArmorRepository _armorRepository;


        public ArmorService(IArmorRepository armorRepository)
        {
            _armorRepository = armorRepository;
        }


        public async Task<ArmorModel> GetOne(int id)
        {
            return await _armorRepository.GetOne(id);
        }
    }
}