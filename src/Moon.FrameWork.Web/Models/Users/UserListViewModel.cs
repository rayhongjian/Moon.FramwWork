using System.Collections.Generic;
using Moon.FrameWork.Roles.Dto;
using Moon.FrameWork.Users.Dto;

namespace Moon.FrameWork.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}