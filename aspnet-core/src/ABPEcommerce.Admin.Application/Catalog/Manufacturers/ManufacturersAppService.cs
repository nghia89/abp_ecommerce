using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABPEcommerce.Admin.Permissions;
using ABPEcommerce.Manufacturers;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ABPEcommerce.Admin.Catalog.Manufacturers
{
    [Authorize(ABPEcommercePermissions.Manufacturer.Default, Policy = "AdminOnly")]
    public class ManufacturersAppService : CrudAppService<
        Manufacturer,
        ManufacturerDto,
        Guid,
        PagedResultRequestDto,
        CreateUpdateManufacturerDto,
        CreateUpdateManufacturerDto>, IManufacturersAppService
    {
        private readonly IRepository<Manufacturer, Guid> _repository;
        public ManufacturersAppService(IRepository<Manufacturer, Guid> repository)
            : base(repository)
        {
            _repository = repository;
            GetPolicyName = ABPEcommercePermissions.Manufacturer.Default;
            GetListPolicyName = ABPEcommercePermissions.Manufacturer.Default;
            CreatePolicyName = ABPEcommercePermissions.Manufacturer.Create;
            UpdatePolicyName = ABPEcommercePermissions.Manufacturer.Update;
            DeletePolicyName = ABPEcommercePermissions.Manufacturer.Delete;
        }

        [Authorize(ABPEcommercePermissions.Manufacturer.Delete)]
        public async Task DeleteMultipleAsync(IEnumerable<Guid> ids)
        {
            await Repository.DeleteManyAsync(ids);
            await UnitOfWorkManager.Current.SaveChangesAsync();
        }

        [Authorize(ABPEcommercePermissions.Manufacturer.Default)]
        public async Task<List<ManufacturerInListDto>> GetListAllAsync()
        {
            var query = await Repository.GetQueryableAsync();
            query = query.Where(x => x.IsActive == true);
            var data = await AsyncExecuter.ToListAsync(query);

            return ObjectMapper.Map<List<Manufacturer>, List<ManufacturerInListDto>>(data);

        }


        [Authorize(ABPEcommercePermissions.Manufacturer.Default)]
        public async Task<PagedResultDto<ManufacturerInListDto>> GetListFilterAsync(BaseListFilterDto input)
        {
            var query = await _repository.GetQueryableAsync();
            query = query.WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Name.Contains(input.Keyword));

            var totalCount = await AsyncExecuter.LongCountAsync(query);
            var data = await AsyncExecuter.ToListAsync(query.Skip(input.SkipCount).Take(input.MaxResultCount));

            return new PagedResultDto<ManufacturerInListDto>(totalCount, ObjectMapper.Map<List<Manufacturer>, List<ManufacturerInListDto>>(data));
        }
    }
}

