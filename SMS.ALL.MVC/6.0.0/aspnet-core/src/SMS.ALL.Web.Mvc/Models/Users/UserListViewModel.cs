using System.Collections.Generic;
using SMS.ALL.Roles.Dto;

namespace SMS.ALL.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
