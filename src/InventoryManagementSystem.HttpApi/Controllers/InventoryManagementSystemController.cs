using InventoryManagementSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class InventoryManagementSystemController : AbpControllerBase
{
    protected InventoryManagementSystemController()
    {
        LocalizationResource = typeof(InventoryManagementSystemResource);
    }
}
