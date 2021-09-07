using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WowApp.Model.Weapon;

namespace WowApp.Database.Weapon
{
    public class WeaponModel : AbstractModel, IWeapon
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
        public int RequiredLevel { get; set; }

        [Required]
        public int Damage { get; set; }

        [Required]
        public float ReloadTime { get; set; }

        [Required]
        public WeaponType Type { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public int BuyPrice { get; set; }

        [Required]
        public int SalePrice { get; set; }


        public static WeaponModel CreateModel(
            string title,
            int damage,
            float reloadTime,
            WeaponType type
        )

        {
            return new WeaponModel
            {
                Title = title,
                Damage = damage,
                ReloadTime = reloadTime,
                Type = type
            };
        }
    }
}