using System.Threading.Tasks;
using WowApp.Model.Weapon;

namespace WowApp.Database.Weapon
{
    public interface IWeaponRepository
    {
        WeaponModel Create(
            string name,
            int damage,
            float reloadTime,
            WeaponType type,
            float range
        );


        Task<WeaponModel> GetOne(int id);


    }
}
