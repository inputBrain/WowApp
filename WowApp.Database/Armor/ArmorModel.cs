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

        [Required] public string Title { get; set; }
        [Required] public string Cover { get; set; }
        [Required] public int RequiredLevel { get; set; }
        [Required] public int PDef { get; set; }
        [Required] public int MDef { get; set; }
        [Required] public float EnhanceLevel { get; set; }
        [Required] public float Weight { get; set; }
        [Required] public float BuyPrice { get; set; }
        [Required] public float SalePrice { get; set; }
        [Required] public ArmorType Type { get; set; }
        [Required] public ArmorGrade Grade { get; set; }


        public static ArmorModel CreateModel(
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
        )
        {
            return new ArmorModel()
            {
                Title = title,
                Cover = cover,
                RequiredLevel = requiredLevel,
                PDef = pDef,
                MDef = mDef,
                EnhanceLevel = enhanceLevel,
                Weight = weight,
                BuyPrice = buyPrice,
                SalePrice = salePrice,
                Type = type,
                Grade = grade
            };
        }
    }
}