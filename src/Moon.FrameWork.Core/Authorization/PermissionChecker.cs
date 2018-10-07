using Abp.Authorization;
using Moon.FrameWork.Authorization.Roles;
using Moon.FrameWork.Authorization.Users;

namespace Moon.FrameWork.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
