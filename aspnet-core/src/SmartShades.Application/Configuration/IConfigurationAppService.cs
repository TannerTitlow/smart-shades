using System.Threading.Tasks;
using SmartShades.Configuration.Dto;

namespace SmartShades.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
