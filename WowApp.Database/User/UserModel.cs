using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WowApp.Database.Armor;
using WowApp.Database.Inventory;
using WowApp.Model.User;

namespace WowApp.Database.User
{
    public class UserModel : AbstractModel, IUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required] public string Nickname { get; set; }
        [Required] public float Hp { get; set; }

        [Required] public uint Level { get; set; }

        [Required] public float Experience { get; set; }

        [Required] public InventoryModel Inventory { get; set; }
        //
        // [Required]
        // public List<ArmorModel> Armors { get; set; }


        public static UserModel CreateModel
        (
            string nickname,
            float hp,
            uint level,
            float experience
        )
        {
            return new UserModel()
            {
                Nickname = nickname,
                Hp = hp,
                Level = level,
                Experience = experience,
                Inventory = InventoryModel.CreateEmpty(),
                // Armors = new List<ArmorModel>()
            };
        }
    }
}