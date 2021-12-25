using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WowApp.Database.User
{
    public class UserStatisticModel : AbstractModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        [ForeignKey("UserId")]
        public UserModel User { get; set; }
        
        [Required]
        public int PK { get; set; }
        
        [Required]
        public int PvP { get; set; }
    }
}