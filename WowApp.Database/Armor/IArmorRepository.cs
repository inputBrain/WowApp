using System.Threading.Tasks;
using WowApp.Model.Armor;

namespace WowApp.Database.Armor
{
    public interface IArmorRepository
    {
        Task<ArmorModel> Create(
            string title,
            string cover,
            int requiredLevel,
            int pDef,
            int mDef,
            float enhanceLevel,
            float weight,
            float buyPrice,
            float salePrice,
            ArmorType type,
            ArmorGrade grade
        );


        Task<ArmorModel> GetOne(int id);
        Task<ArmorModel> GetTitle(int id);

    }
}