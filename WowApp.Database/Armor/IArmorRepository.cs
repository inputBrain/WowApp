using System.Threading.Tasks;
using WowApp.Model.Armor;

namespace WowApp.Database.Armor
{
    public interface IArmorRepository
    {
        Task<ArmorModel> Create(
            string title,
            float defence,
            float weight,
            float temperatureProtection,
            ArmorType type
        );


        Task<ArmorModel> GetOne(int id);
        Task<ArmorModel> GetTitle(int id);

    }
}