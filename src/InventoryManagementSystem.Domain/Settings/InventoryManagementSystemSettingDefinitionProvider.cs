using Volo.Abp.Settings;

namespace InventoryManagementSystem.Settings;

public class InventoryManagementSystemSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(InventoryManagementSystemSettings.MySetting1));
    }
}
