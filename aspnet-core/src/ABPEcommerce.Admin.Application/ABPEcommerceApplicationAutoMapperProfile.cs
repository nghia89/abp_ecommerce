using ABPEcommerce.Admin.ProductCategories;
using ABPEcommerce.ProductCategoties;
using AutoMapper;

namespace ABPEcommerce.Admin;

public class ABPEcommerceApplicationAutoMapperProfile : Profile
{
    public ABPEcommerceApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

    }
}
