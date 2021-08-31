using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace WowApp.Database
{
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