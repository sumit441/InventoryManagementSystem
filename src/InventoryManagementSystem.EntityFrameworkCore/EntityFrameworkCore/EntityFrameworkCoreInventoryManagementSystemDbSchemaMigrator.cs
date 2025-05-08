using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using InventoryManagementSystem.Data;
using Volo.Abp.DependencyInjection;

namespace InventoryManagementSystem.EntityFrameworkCore;

public class EntityFrameworkCoreInventoryManagementSystemDbSchemaMigrator
    : IInventoryManagementSystemDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreInventoryManagementSystemDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the InventoryManagementSystemDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<InventoryManagementSystemDbContext>()
            .Database
            .MigrateAsync();
    }
}
