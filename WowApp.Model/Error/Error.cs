namespace WowApp.Model.Error
{
    public sealed class Error
    {
        public readonly ErrorCode Code;

        public readonly string Message;


        public Error(ErrorCode code, string message)
        {
            Code = code;
            Message = message;
        }


        private enum Base
        {
            General = 0,
            User = 100
        }


        public enum ErrorCode
        {

        }

    }
}