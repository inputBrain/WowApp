using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
        protected readonly DbSet<T> DbModel;

        protected readonly PostgreSqlContext Context;

        protected readonly ILogger<T> Logger;

        protected AbstractRepository(PostgreSqlContext context, ILoggerFactory loggerFactory)
        {
            Context = context;
            DbModel = context.Set<T>();
            Logger = loggerFactory.CreateLogger<T>();
        }


        protected async Task<T> FindOne(int id)
        {
            var model = await DbModel.FindAsync(id);
            return model;
        }


        protected async Task<T> CreateModelAsync(T model)
        {
            await Context.AddAsync(model);
            var result = await Context.SaveChangesAsync();
            if (result == 0)
            {
                throw new Exception("Db Error. Not created any model");
            }

            return model;
        }


        protected void Delete(T entity)
        {
            Context.Remove(entity);
        }


        protected async void DeleteModel(T model)
        {
            Delete(model);
            var result = await Context.SaveChangesAsync();
            if (result == 0)
            {
                throw new Exception("Db error. Not deleted");
            }
        }
    }
}