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

        [Required]
        public string Cover { get; set; }

        [Required]
        public int EnhanceLevel { get; set; }

        [Required]
        public ArmorGrade Grade { get; set; }

        [Required]
        public ArmorType Type { get; set; }

        [Required]
        public int RequiredLevel { get; set; }

        [Required]
        public int PhysicDefence { get; set; }

        [Required]
        public int MagicalDefence { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public int BuyPrice { get; set; }

        [Required]
        public int SalePrice { get; set; }
    }
}