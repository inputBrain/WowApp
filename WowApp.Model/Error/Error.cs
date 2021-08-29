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
            #region General

            NoError = Base.General,
            DbError,
            UnknownError,
            Auth,
            Invalid,

            #endregion

            #region User

            UserNotFound = Base.User + 1,
            InvalidLogin,
            InvalidPassword,

            #endregion
        }

        public static Error DbError(string message = "Db Error") =>
            new Error(ErrorCode.DbError, message);


        public static Error UnknownError(string mesage = "Unknown Error") =>
            new Error(ErrorCode.UnknownError, mesage);


        public static Error AuthError(string message = "User is not authorized. Auth error") =>
            new Error(ErrorCode.Auth, message);


        public static Error InvalidError(string message = "Invalid Error") =>
            new Error(ErrorCode.Invalid, message);


        public static Error UserNotFound(string message = "User not found error") =>
            new Error(ErrorCode.UserNotFound, message);


        public static Error InvalidLogin(string message) =>
            new Error(ErrorCode.InvalidLogin, message);


        public static Error InvalidPassword(string message = "Password invalid") =>
            new Error(ErrorCode.InvalidPassword, message);
    }
}