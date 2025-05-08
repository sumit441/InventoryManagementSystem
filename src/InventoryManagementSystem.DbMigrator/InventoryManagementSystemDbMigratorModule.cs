using InventoryManagementSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace InventoryManagementSystem.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(InventoryManagementSystemEntityFrameworkCoreModule),
    typeof(InventoryManagementSystemApplicationContractsModule)
)]
public class InventoryManagementSystemDbMigratorModule : AbpModule
{
}
