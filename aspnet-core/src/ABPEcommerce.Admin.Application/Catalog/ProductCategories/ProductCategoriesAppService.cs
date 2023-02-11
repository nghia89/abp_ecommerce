using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABPEcommerce.Admin.Permissions;
using ABPEcommerce.ProductCategories;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ABPEcommerce.Admin.Catalog.ProductCategories
{
    [Authorize(ABPEcommercePermissions.ProductCategory.Default, Policy = "AdminOnly")]
    public class ProductCategoriesAppService : CrudAppService<
        ProductCategory,
        ProductCategoryDto,
        Guid,
        PagedResultRequestDto,
        CreateUpdateProductCategoryDto,
        CreateUpdateProductCategoryDto>, IProductCategoriesAppService
    {
        private readonly IRepository<ProductCategory, Guid> _repository;
        public ProductCategoriesAppService(IRepository<ProductCategory, Guid> repository)
            : base(repository)
        {
            _repository = repository;
            GetPolicyName = ABPEcommercePermissions.ProductCategory.Default;
            GetListPolicyName = ABPEcommercePermissions.ProductCategory.Default;
            CreatePolicyName = ABPEcommercePermissions.ProductCategory.Create;
            UpdatePolicyName = ABPEcommercePermissions.ProductCategory.Update;
            DeletePolicyName = ABPEcommercePermissions.ProductCategory.Delete;
        }

        [Authorize(ABPEcommercePermissions.ProductCategory.Default)]
        public async Task<List<ProductCategoryInListDto>> GetListAllAsync()
        {
            var query = await Repository.GetQueryableAsync();
            query = query.Where(x => x.IsActive == true);
            var data = await AsyncExecuter.ToListAsync(query);

            return ObjectMapper.Map<List<ProductCategory>, List<ProductCategoryInListDto>>(data);

        }


        [Authorize(ABPEcommercePermissions.ProductCategory.Default)]
        public async Task<PagedResultDto<ProductCategoryInListDto>> GetListFilterAsync(BaseListFilterDto input)
        {
            var query = await _repository.GetQueryableAsync();
            query = query.WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Name.Contains(input.Keyword));

            var totalCount = await AsyncExecuter.LongCountAsync(query);
            var data = await AsyncExecuter.ToListAsync(query.Skip(input.SkipCount).Take(input.MaxResultCount));

            return new PagedResultDto<ProductCategoryInListDto>(totalCount, ObjectMapper.Map<List<ProductCategory>, List<ProductCategoryInListDto>>(data));
        }
    }
}

