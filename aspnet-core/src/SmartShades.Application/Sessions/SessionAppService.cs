using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Auditing;
using SmartShades.Sessions.Dto;

namespace SmartShades.Sessions
{
    public class SessionAppService : SmartShadesAppServiceBase, ISessionAppService
    {
        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput
            {
                Application = new ApplicationInfoDto
                {
                    Version = AppVersionHelper.Version,
                    ReleaseDate = AppVersionHelper.ReleaseDate,
                    Features = new Dictionary<string, bool>()
                }
            };

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = ObjectMapper.Map<TenantLoginInfoDto>(await GetCurrentTenantAsync());
            }

            if (AbpSession.UserId.HasValue)
            {
                output.User = ObjectMapper.Map<UserLoginInfoDto>(await GetCurrentUserAsync());
            }

            return output;
        }


        [DisableAuditing]
        public async Task<bool> IsCurrentUserInRole(string role)
        {
            var inRole = false;
            if (AbpSession.UserId.HasValue)
            {
                Authorization.Users.User user = await GetCurrentUserAsync();
                inRole = await UserManager.IsInRoleAsync(user, role);
            }

            return inRole;
        }

    }
}
