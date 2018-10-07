using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Moon.FrameWork.Configuration.Dto;

namespace Moon.FrameWork.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FrameWorkAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
