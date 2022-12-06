using System.Collections.Generic;
using SmartShades.Roles.Dto;

namespace SmartShades.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
