using System.Threading.Tasks;
using Abp.Application.Services;
using SmartShades.Sessions.Dto;

namespace SmartShades.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        /// <summary>
        /// Find whether or not current user is in specified role
        /// </summary>
        /// <returns>Flag to indicate if current user is in specified role</returns>
        Task<bool> IsCurrentUserInRole(string role);
    }
}
