using Microsoft.Extensions.Logging;

namespace WowApp.Database.Inventory
{
    public class InventoryRepository : AbstractRepository<InventoryModel>, IInventoryRepository
    {
        public InventoryRepository(PostgreSqlContext context, ILoggerFactory loggerFactory) : base(context, loggerFactory)
        {
        }
    }
}