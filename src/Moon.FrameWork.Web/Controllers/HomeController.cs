using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Moon.FrameWork.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FrameWorkControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}