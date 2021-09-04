using System.Threading.Tasks;
using WowApp.Database.Weapon;

namespace WowApp.Database.Service
{
    public class WeaponService: IWeaponService
    {
        private readonly IWeaponRepository _weaponRepository;


        public WeaponService(IWeaponRepository weaponRepository)
        {
            _weaponRepository = weaponRepository;
        }


        public async Task<WeaponModel> GetOne(int id)
        {
            return await _weaponRepository.GetOne(id);
        }
    }
}