﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ABPEcommerce.Public.Products.Attributes;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ABPEcommerce.Public.Products
{
    public interface IProductsAppService : IReadOnlyAppService
        <ProductDto,
        Guid, 
        PagedResultRequestDto>
    {
        Task<PagedResultDto<ProductInListDto>> GetListFilterAsync(ProductListFilterDto input);
        Task<List<ProductInListDto>> GetListAllAsync();
        Task<string> GetThumbnailImageAsync(string fileName);
        Task<List<ProductAttributeValueDto>> GetListProductAttributeAllAsync(Guid productId);
        Task<PagedResultDto<ProductAttributeValueDto>> GetListProductAttributesAsync(ProductAttributeListFilterDto input);

    }
}
