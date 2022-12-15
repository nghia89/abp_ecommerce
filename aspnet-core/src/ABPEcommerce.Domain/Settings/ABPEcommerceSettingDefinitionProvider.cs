using Volo.Abp.Settings;

namespace ABPEcommerce.Settings;

public class ABPEcommerceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABPEcommerceSettings.MySetting1));
    }
}
