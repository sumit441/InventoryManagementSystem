using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace InventoryManagementSystem.Data;

/* This is used if database provider does't define
 * IInventoryManagementSystemDbSchemaMigrator implementation.
 */
public class NullInventoryManagementSystemDbSchemaMigrator : IInventoryManagementSystemDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
