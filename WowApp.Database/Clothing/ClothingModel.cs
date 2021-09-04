using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WowApp.Model.Clothing;

namespace WowApp.Database.Clothing
{
    public class ClothingModel : AbstractModel, IClothingModel
    {
        [Key]
        [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
        public int Id { get; set; }

        [Required] public string? Title { get; set; }
        [Required] public float Defence { get; set; }
        [Required] public float Weight { get; set; }
        [Required] public float TemperatureProtection { get; set; }
        [Required] public ClothingType Type { get; set; }

        public static ClothingModel CreateModel
        (
            int id,
            string title,
            float defence,
            float weight,
            float temperatureProtection,
            ClothingType type
        )
        {
            return new ClothingModel()
            {
                Id = id,
                Title = title,
                Defence = defence,
                Weight = weight,
                TemperatureProtection = temperatureProtection,
                Type = type
            };
        }
    }
}