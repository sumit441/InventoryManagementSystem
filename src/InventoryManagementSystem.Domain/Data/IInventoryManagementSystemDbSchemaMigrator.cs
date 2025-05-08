using System.Threading.Tasks;

namespace InventoryManagementSystem.Data;

public interface IInventoryManagementSystemDbSchemaMigrator
{
    Task MigrateAsync();
}
