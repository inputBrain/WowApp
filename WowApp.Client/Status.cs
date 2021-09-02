using System.ComponentModel.DataAnnotations;

namespace WowApp.Client
{
    public sealed class Status
    {
        [Required]
        public ErrorCode ErrorCode { get; set; }


        public static Status Ok()
        {
            return new Status()
            {
                ErrorCode = ErrorCode.NoError
            };
        }
    }
}