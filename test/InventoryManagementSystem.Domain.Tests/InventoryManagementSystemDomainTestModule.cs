using Volo.Abp.Modularity;

namespace InventoryManagementSystem;

[DependsOn(
    typeof(InventoryManagementSystemDomainModule),
    typeof(InventoryManagementSystemTestBaseModule)
)]
public class InventoryManagementSystemDomainTestModule : AbpModule
{

}
