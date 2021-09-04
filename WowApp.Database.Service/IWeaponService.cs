using System.Threading.Tasks;
using WowApp.Database.Weapon;

namespace WowApp.Database.Service
{
    public interface IWeaponService
    {
        Task<WeaponModel> GetOne(int id);
    }
}