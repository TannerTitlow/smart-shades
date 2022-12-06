using System.Threading.Tasks;
using Abp.Application.Services;
using SmartShades.Authorization.Accounts.Dto;

namespace SmartShades.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
