using System.Collections.Generic;
using SmartShades.Roles.Dto;

namespace SmartShades.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}