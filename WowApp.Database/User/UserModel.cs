using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WowApp.Database.Inventory;
using WowApp.Model.User;

namespace WowApp.Database.User
{
    public class UserModel : AbstractModel, IUserModel//��������� ����� ����������� ������ ��������
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Cover { get; set; }

        [Required]
        public UserRole Role { get; set; }

        [Required]
        public Status Status { get; set; }


        [Required]
        public InventoryModel Inventory { get; set; }


        public static UserModel CreateModel//�������� ���� ������ ��� �������� ��������
        (
            string firstName,
            string lastName,
            string cover,
            UserRole role
        )
        {
            return new UserModel()//���������� ������
            {
                FirstName = firstName,
                LastName = lastName,
                Cover = cover,
                Role = role,
                Inventory = new InventoryModel()
            };
        }
    }
}