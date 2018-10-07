using System.Collections.Generic;
using Moon.FrameWork.Roles.Dto;

namespace Moon.FrameWork.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}