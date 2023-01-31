using ABPEcommerce.Admin.Catalog.Manufacturers;
using ABPEcommerce.Admin.Catalog.ProductAttributes;
using ABPEcommerce.Admin.Catalog.ProductCategories;
using ABPEcommerce.Admin.Catalog.Products;
using ABPEcommerce.Admin.System.Roles;
using ABPEcommerce.Admin.System.Users;
using ABPEcommerce.Attributes;
using ABPEcommerce.Manufacturers;
using ABPEcommerce.ProductCategoties;
using ABPEcommerce.Products;
using ABPEcommerce.Roles;
using AutoMapper;
using Volo.Abp.Identity;

namespace ABPEcommerce.Admin;

public class ABPEcommerceApplicationAutoMapperProfile : Profile
{
    public ABPEcommerceApplicationAutoMapperProfile()
    {
        //Product Category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

        //Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
        CreateMap<CreateUpdateProductDto, Product>();

        //Manufacturers
        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Manufacturer, ManufacturerInListDto>();
        CreateMap<CreateUpdateManufacturerDto, Manufacturer>();

        //Product attribute
        CreateMap<ProductAttribute, ProductAttributeDto>();
        CreateMap<ProductAttribute, ProductAttributeInListDto>();
        CreateMap<CreateUpdateProductAttributeDto, ProductAttribute>();

        //Roles
        CreateMap<IdentityRole, RoleDto>().ForMember(x => x.Description,
            map => map.MapFrom(x => x.ExtraProperties.ContainsKey(RoleConsts.DescriptionFieldName)
            ?
            x.ExtraProperties[RoleConsts.DescriptionFieldName]
            :
            null));
        CreateMap<IdentityRole, RoleInListDto>().ForMember(x => x.Description,
            map => map.MapFrom(x => x.ExtraProperties.ContainsKey(RoleConsts.DescriptionFieldName)
            ?
            x.ExtraProperties[RoleConsts.DescriptionFieldName]
            :
            null));
        CreateMap<CreateUpdateRoleDto, IdentityRole>();

        //User
        CreateMap<IdentityUser, UserDto>();
        CreateMap<IdentityUser, UserInListDto>();
    }
}
