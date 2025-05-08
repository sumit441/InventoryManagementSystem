using InventoryManagementSystem.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace InventoryManagementSystem.Web.Pages;

public abstract class InventoryManagementSystemPageModel : AbpPageModel
{
    protected InventoryManagementSystemPageModel()
    {
        LocalizationResourceType = typeof(InventoryManagementSystemResource);
    }
}
