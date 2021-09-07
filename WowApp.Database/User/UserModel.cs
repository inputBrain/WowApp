using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WowApp.Database.Inventory;
using WowApp.Model.User;

namespace WowApp.Database.User
{
    public class UserModel : AbstractModel, IUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Nickname { get; set; }

        [Required]
        public int Hp { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        public int Level { get; set; }

        // [Required]
        // public InventoryModel Inventory { get; set; }

        // [Required]
        // public List<ArmorModel> Armors { get; set; }
    }
}