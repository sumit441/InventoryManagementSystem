using Volo.Abp.Modularity;

namespace InventoryManagementSystem;

public abstract class InventoryManagementSystemApplicationTestBase<TStartupModule> : InventoryManagementSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
