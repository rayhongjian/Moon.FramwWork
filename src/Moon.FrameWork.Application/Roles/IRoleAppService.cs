using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Moon.FrameWork.Roles.Dto;

namespace Moon.FrameWork.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
