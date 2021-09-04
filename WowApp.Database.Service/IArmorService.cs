using System.Threading.Tasks;
using WowApp.Database.Armor;

namespace WowApp.Database.Service
{
    public interface IArmorService
    {
        Task<ArmorModel> GetOne(int id);
    }
}