using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Moon.FrameWork.Roles.Dto;
using Moon.FrameWork.Users.Dto;

namespace Moon.FrameWork.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}