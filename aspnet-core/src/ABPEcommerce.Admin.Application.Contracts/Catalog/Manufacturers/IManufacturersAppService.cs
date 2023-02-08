using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ABPEcommerce.Admin.Catalog.Manufacturers
{
    public interface IManufacturersAppService : ICrudAppService
        <ManufacturerDto,
        Guid,
        PagedResultRequestDto,
        CreateUpdateManufacturerDto,
        CreateUpdateManufacturerDto>
    {
        Task DeleteMultipleAsync(IEnumerable<Guid> ids);
        Task<List<ManufacturerInListDto>> GetListAllAsync();
        Task<PagedResultDto<ManufacturerInListDto>> GetListFilterAsync(BaseListFilterDto input);
    }
}

