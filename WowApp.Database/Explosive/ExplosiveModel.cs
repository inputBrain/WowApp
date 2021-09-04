using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WowApp.Database.Weapon;
using WowApp.Model.Explosive;

namespace WowApp.Database.Explosive
{
    public class ExplosiveModel : IExplosive
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