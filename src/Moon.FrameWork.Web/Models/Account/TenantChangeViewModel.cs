using Abp.AutoMapper;
using Moon.FrameWork.Sessions.Dto;

namespace Moon.FrameWork.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}