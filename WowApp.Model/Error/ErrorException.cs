using System;

namespace WowApp.Model.Error
{
    public class ErrorException : Exception
    {
        public readonly Error Error;


        public ErrorException(Error error) : base(error.Message)
        {
            Error = error;
        }
    }
}