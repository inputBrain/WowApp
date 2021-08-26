namespace WowApp.Host.Models.Weapons.Axe
{
    public interface IAxe
    {
        int Id { get; }

        string Color { get; }

        AxeModel CreateAxe(string color);

        string GetInfo(AxeModel model, bool isFullInfo);
    }
}