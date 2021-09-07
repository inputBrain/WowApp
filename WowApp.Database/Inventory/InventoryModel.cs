using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WowApp.Database.User;
using WowApp.Model.Inventory;

namespace WowApp.Database.Inventory
{
    public class InventoryModel : AbstractModel, IInventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public UserModel User { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public int MaxSize { get; set; }

        [Required]
        public int ExtendedSize { get; set; }


        public static InventoryModel CreateEmpty(
            int size = 0,
            int maxSize = 20,
            int extendedSize = 0
        )
        {
            return new InventoryModel()
            {
                Size = size,
                MaxSize = maxSize,
                ExtendedSize = extendedSize
            };
        }
    }
}