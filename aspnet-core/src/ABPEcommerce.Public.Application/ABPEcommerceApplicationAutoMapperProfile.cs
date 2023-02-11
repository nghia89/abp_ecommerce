
using ABPEcommerce.Attributes;
using ABPEcommerce.Manufacturers;
using ABPEcommerce.ProductCategories;
using ABPEcommerce.Products;
using ABPEcommerce.Public.Manufacturers;
using ABPEcommerce.Public.ProductAttributes;
using ABPEcommerce.Public.ProductCategories;
using ABPEcommerce.Public.Products;
using ABPEcommerce.Roles;
using AutoMapper;
using Volo.Abp.Identity;

namespace ABPEcommerce.Public;

public class ABPEcommerceApplicationAutoMapperProfile : Profile
{
    public ABPEcommerceApplicationAutoMapperProfile()
    {
        //Product Category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
 
        //Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
 
        //Manufacturers
        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Manufacturer, ManufacturerInListDto>();
 
        //Product attribute
        CreateMap<ProductAttribute, ProductAttributeDto>();
        CreateMap<ProductAttribute, ProductAttributeInListDto>();
 
    }
}
