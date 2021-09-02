using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WowApp.Database.Inventory
{
    public class InventoryModel : AbstractModel, IInventoryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public int MaxSize { get; set; }

        [Required]
        public int Money { get; set; }
    }
}