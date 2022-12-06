using System.Collections.Generic;
using SmartShades.Roles.Dto;

namespace SmartShades.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
