using System.Threading.Tasks;
using WowApp.Model.Clothing;

namespace WowApp.Database.Clothing
{
    public interface IClothingRepository
    {
        Task<ClothingModel> Create(
            int id,
            string title,
            float defence,
            float weight,
            float temperatureProtection,
            ClothingType type
   
        );
        
    }
}