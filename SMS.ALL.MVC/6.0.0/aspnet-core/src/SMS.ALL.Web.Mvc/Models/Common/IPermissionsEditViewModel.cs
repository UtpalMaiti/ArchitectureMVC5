using System.Collections.Generic;
using SMS.ALL.Roles.Dto;

namespace SMS.ALL.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}