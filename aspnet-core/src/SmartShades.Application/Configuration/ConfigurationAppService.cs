using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SmartShades.Configuration.Dto;

namespace SmartShades.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SmartShadesAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
