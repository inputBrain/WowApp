using System.ComponentModel.DataAnnotations;

namespace WowApp.Client.User
{
    public sealed class GetOneUser
    {
        [Required]
        public int UserId { get; set; }


        public sealed class Response : AbstractResponse
        {
            [Required]
            public Payload.User.User User { get; }

            public Response(Payload.User.User user)
            {
                User = user;
            }
        }
    }
}