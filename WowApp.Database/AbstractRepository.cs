using Microsoft.Extensions.Logging;

namespace WowApp.Database
{
    // Абстрактные классы нужны для того, чтобы выделить общий функционал для семейства классов.
    // Так как репозитории работают с базой данных, в этом абстрактном классе будет описана логика запросов к базе
    // Например, сохранить нашу модельку. Моделек может быть много, а логика по сохранению модельки одна и та же.

    // ...Repository<T> where T : AbstractModel — указываем, что классы которые будут наследоваться от этого абстрактного класса
    // Должны определять дженерик (буква T) классы которые наследуются от AbstractModel.

    // А еще, это защита от дурака.
    public abstract class AbstractRepository<T> where T : AbstractModel
    {
        protected ILogger<T> Logger;


        protected AbstractRepository(ILoggerFactory loggerFactory)
        {
            Logger = loggerFactory.CreateLogger<T>();
        }
    }
}