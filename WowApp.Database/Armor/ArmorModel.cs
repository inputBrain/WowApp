using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WowApp.Model.Armor;

namespace WowApp.Database.Armor
{
    public class ArmorModel : AbstractModel, IArmor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }


        //TODO: Def, Wei, Tem...
        [Required]
        public float Defence { get; set; }

        [Required]
        public float Weight { get; set; }

        [Required]
        public float TemperatureProtection { get; set; }

        [Required]
        public ArmorType Type { get; set; }


        public static ArmorModel CreateModel(
            string title,
            float defence,
            float weight,
            float temperatureProtection,
            ArmorType type
        )
        {
            return new ArmorModel()
            {
                Title = title,
                Defence = defence,
                Weight = weight,
                TemperatureProtection = temperatureProtection,
                Type = type
            };
        }
    }
}