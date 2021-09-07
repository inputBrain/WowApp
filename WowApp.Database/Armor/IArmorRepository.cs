using System.Threading.Tasks;

namespace WowApp.Database.Armor
{
    public interface IArmorRepository
    {
        Task<ArmorModel> GetOne(int id);
    }
}