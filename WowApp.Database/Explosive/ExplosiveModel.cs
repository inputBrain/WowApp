using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WowApp.Database.Weapon;

namespace WowApp.Database.Explosive
{
    public class ExplosiveModel : IExplosiveModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int WeaponId { get; set; }

        [ForeignKey("WeaponId")]
        public WeaponModel Weapon { get; set; }

        [Required]
        public float Range { get; set; }
    }
}