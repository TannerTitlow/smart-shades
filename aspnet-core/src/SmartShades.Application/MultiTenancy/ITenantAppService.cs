using Abp.Application.Services;
using SmartShades.MultiTenancy.Dto;

namespace SmartShades.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

