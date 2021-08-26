namespace WowApp.Host.Models.Weapons.Knife
{
    public interface IKnife
    {
        int Id { get; }

        string Color { get; }

        void GetInfo(KnifeModel model, bool isFullInfo);

    }
}