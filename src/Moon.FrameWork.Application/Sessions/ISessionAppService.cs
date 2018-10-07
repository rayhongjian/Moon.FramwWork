using System.Threading.Tasks;
using Abp.Application.Services;
using Moon.FrameWork.Sessions.Dto;

namespace Moon.FrameWork.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
