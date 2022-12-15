using ABPEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABPEcommerce.Admin.Permissions;

public class ABPEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ABPEcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ABPEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ABPEcommerceResource>(name);
    }
}
