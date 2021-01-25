using System.Collections.Generic;
using SMS.ALL.Roles.Dto;

namespace SMS.ALL.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
