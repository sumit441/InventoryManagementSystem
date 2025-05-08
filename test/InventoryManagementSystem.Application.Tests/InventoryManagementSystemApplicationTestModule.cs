using Volo.Abp.Modularity;

namespace InventoryManagementSystem;

[DependsOn(
    typeof(InventoryManagementSystemApplicationModule),
    typeof(InventoryManagementSystemDomainTestModule)
)]
public class InventoryManagementSystemApplicationTestModule : AbpModule
{

}
