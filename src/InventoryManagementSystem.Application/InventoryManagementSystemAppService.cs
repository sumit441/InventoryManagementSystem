using InventoryManagementSystem.Localization;
using Volo.Abp.Application.Services;

namespace InventoryManagementSystem;

/* Inherit your application services from this class.
 */
public abstract class InventoryManagementSystemAppService : ApplicationService
{
    protected InventoryManagementSystemAppService()
    {
        LocalizationResource = typeof(InventoryManagementSystemResource);
    }
}
