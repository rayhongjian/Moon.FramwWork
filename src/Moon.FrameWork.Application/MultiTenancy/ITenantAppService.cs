using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Moon.FrameWork.MultiTenancy.Dto;

namespace Moon.FrameWork.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
