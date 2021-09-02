using WowApp.Client.Payload.User;
using WowApp.Model.Error;
using  WowApp.Model.User;

namespace WowApp.Client.Codec
{
    public static class UserCodec
    {
        public static Payload.User.User EncodeUser(IUser dbModel)
        {
            return new Payload.User.User()
            {
                Id = dbModel.Id,
                FirstName = dbModel.FirstName,
                LastName = dbModel.LastName,
                Cover = dbModel.Cover,
                Role = EncodeRole(dbModel.Role).ToString()
            };
        }


        private static Payload.User.Role EncodeRole(UserRole role)
        {
            switch (role)
            {
                case UserRole.Admin:
                    return Role.Admin;
                case UserRole.Manager:
                    return Role.Manager;
                default:
                    throw new ErrorException(Error.UnknownError($"Role {role.ToString()} undefined. Cannot encode."));
            }
        }
    }
}