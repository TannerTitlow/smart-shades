using System.Threading.Tasks;
using Abp.Application.Services;
using SmartShades.Sessions.Dto;

namespace SmartShades.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
