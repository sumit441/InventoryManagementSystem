using InventoryManagementSystem.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace InventoryManagementSystem.Permissions;

public class InventoryManagementSystemPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(InventoryManagementSystemPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(InventoryManagementSystemPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<InventoryManagementSystemResource>(name);
    }
}
