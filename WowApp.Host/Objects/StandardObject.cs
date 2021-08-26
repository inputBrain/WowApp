using WowApp.Host.Interfaces;

namespace WowApp.Host.Objects
{

    public abstract class StandardObject: IGetInfo//Абстрактный класс реализует интерфейс с последующим наследованием
    {
        public abstract string Name { get; set; }
        public abstract string Color { get; set; }
        public abstract int Id { get; set; }
        public abstract void ShowInfo(string infoType);
    }
}
