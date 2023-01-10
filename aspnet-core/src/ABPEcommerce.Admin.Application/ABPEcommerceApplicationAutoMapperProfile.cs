using ABPEcommerce.Admin.Manufacturers;
using ABPEcommerce.Admin.ProductAttributes;
using ABPEcommerce.Admin.ProductCategories;
using ABPEcommerce.Admin.Products;
using ABPEcommerce.Attributes;
using ABPEcommerce.Manufacturers;
using ABPEcommerce.ProductCategoties;
using ABPEcommerce.Products;
using AutoMapper;

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
    }
}
