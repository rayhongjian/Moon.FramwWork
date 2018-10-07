using System.Threading.Tasks;
using Abp.Application.Services;
using Moon.FrameWork.Configuration.Dto;

namespace Moon.FrameWork.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}