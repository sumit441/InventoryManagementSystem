using Volo.Abp.Modularity;

namespace InventoryManagementSystem;

/* Inherit from this class for your domain layer tests. */
public abstract class InventoryManagementSystemDomainTestBase<TStartupModule> : InventoryManagementSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
