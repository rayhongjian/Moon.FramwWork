using System.Threading.Tasks;
using Abp.Application.Services;
using Moon.FrameWork.Authorization.Accounts.Dto;

namespace Moon.FrameWork.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
