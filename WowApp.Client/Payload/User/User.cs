using System.ComponentModel.DataAnnotations;

namespace WowApp.Client.Payload.User
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Cover { get; set; }

        [Required]
        public string Role { get; set; }
    }
}