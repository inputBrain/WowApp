using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using WowApp.Host;

namespace WowApp.Database.Test
{
    internal sealed class Fixture : IDisposable
    {
        private PostgreSqlContext _postgreSqlContext;
        public DatabaseContainer DatabaseContainer;


        public Fixture(PostgreSqlContext postgreSqlContext)
        {
            _postgreSqlContext = postgreSqlContext;
            DatabaseContainer = (DatabaseContainer) postgreSqlContext.Db;
        }


        public static Fixture Create()
        {
            var guid = Guid.NewGuid().ToString("N");
            var option = new DbContextOptionsBuilder<PostgreSqlContext>()
                .UseNpgsql
                (
                    "User ID=postgres;Password=123;Host=localhost;Port=5432;Database=wowapp_test_" + guid +
                    ";Pooling=true;",
                    b => b.MigrationsAssembly(typeof(Startup).Assembly.GetName().Name)
                )
                .Options;
            var content = new PostgreSqlContext(option, new NullLoggerFactory());
            content.Database.Migrate();
            return new Fixture(content);
        }


        public void Dispose()
        {
            if (_postgreSqlContext == null)
            {
                return;
            }

            _postgreSqlContext.Database.EnsureDeleted();
            _postgreSqlContext?.Dispose();
        }
    }
}