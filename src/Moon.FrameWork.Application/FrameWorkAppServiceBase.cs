using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Moon.FrameWork.Authorization.Users;
using Moon.FrameWork.MultiTenancy;
using Moon.FrameWork.Users;
using Microsoft.AspNet.Identity;

namespace Moon.FrameWork
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class FrameWorkAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected FrameWorkAppServiceBase()
        {
            LocalizationSourceName = FrameWorkConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}