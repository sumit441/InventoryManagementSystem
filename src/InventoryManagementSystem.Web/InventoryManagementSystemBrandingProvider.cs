using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using InventoryManagementSystem.Localization;

namespace InventoryManagementSystem.Web;

[Dependency(ReplaceServices = true)]
public class InventoryManagementSystemBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<InventoryManagementSystemResource> _localizer;

    public InventoryManagementSystemBrandingProvider(IStringLocalizer<InventoryManagementSystemResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
