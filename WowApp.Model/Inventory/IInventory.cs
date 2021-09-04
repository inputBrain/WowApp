namespace WowApp.Model.Inventory
{
    public interface IInventory
    {

        //TODO:
        int Id { get; }

        int Size { get; }

        int MaxSize { get; }

        int Money { get; }
    }
}