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
            };
        }
    }
}