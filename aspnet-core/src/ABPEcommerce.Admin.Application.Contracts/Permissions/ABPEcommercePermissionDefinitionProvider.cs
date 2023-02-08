using ABPEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABPEcommerce.Admin.Permissions;

public class ABPEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
         var catalogGroup = context.AddGroup(ABPEcommercePermissions.CatalogGroupName, L("Permission:Catalog"));

        //Add product
        var productPermission = catalogGroup.AddPermission(ABPEcommercePermissions.Product.Default, L("Permission:Catalog.Product"));
        productPermission.AddChild(ABPEcommercePermissions.Product.Create, L("Permission:Catalog.Product.Create"));
        productPermission.AddChild(ABPEcommercePermissions.Product.Update, L("Permission:Catalog.Product.Update"));
        productPermission.AddChild(ABPEcommercePermissions.Product.Delete, L("Permission:Catalog.Product.Delete"));
        productPermission.AddChild(ABPEcommercePermissions.Product.AttributeManage, L("Permission:Catalog.Product.AttributeManage"));

        //Manufacture
        var manufacturerPermission = catalogGroup.AddPermission(ABPEcommercePermissions.Manufacturer.Default, L("Permission:Catalog.Manufacturer"));
        manufacturerPermission.AddChild(ABPEcommercePermissions.Manufacturer.Create, L("Permission:Catalog.Manufacturer.Create"));
        manufacturerPermission.AddChild(ABPEcommercePermissions.Manufacturer.Update, L("Permission:Catalog.Manufacturer.Update"));
        manufacturerPermission.AddChild(ABPEcommercePermissions.Manufacturer.Delete, L("Permission:Catalog.Manufacturer.Delete"));

        //Product Category
        var productCategoryPermission = catalogGroup.AddPermission(ABPEcommercePermissions.ProductCategory.Default, L("Permission:Catalog.ProductCategory"));
        productCategoryPermission.AddChild(ABPEcommercePermissions.ProductCategory.Create, L("Permission:Catalog.ProductCategory.Create"));
        productCategoryPermission.AddChild(ABPEcommercePermissions.ProductCategory.Update, L("Permission:Catalog.ProductCategory.Update"));
        productCategoryPermission.AddChild(ABPEcommercePermissions.ProductCategory.Delete, L("Permission:Catalog.ProductCategory.Delete"));

        //Add attribute
        var attributePermission = catalogGroup.AddPermission(ABPEcommercePermissions.Attribute.Default, L("Permission:Catalog.Attribute"));
        attributePermission.AddChild(ABPEcommercePermissions.Attribute.Create, L("Permission:Catalog.Attribute.Create"));
        attributePermission.AddChild(ABPEcommercePermissions.Attribute.Update, L("Permission:Catalog.Attribute.Update"));
        attributePermission.AddChild(ABPEcommercePermissions.Attribute.Delete, L("Permission:Catalog.Attribute.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ABPEcommerceResource>(name);
    }
}
