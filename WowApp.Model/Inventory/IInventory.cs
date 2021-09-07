namespace WowApp.Model.Inventory
{
    public interface IInventory
    {
        int Id { get; }

        int Size { get; }

        int MaxSize { get; }

        int ExtendedSize { get; }
    }
}