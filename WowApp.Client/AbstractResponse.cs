using System;
using System.ComponentModel.DataAnnotations;

namespace WowApp.Client
{
    public abstract class AbstractResponse
    {
        [Required]
        public Status Status;

        [Required]
        public int ServerTimestamp;


        protected AbstractResponse()
        {
            Status = Status.Ok();
            ServerTimestamp = DateTime.UtcNow.Second;
        }
    }
}