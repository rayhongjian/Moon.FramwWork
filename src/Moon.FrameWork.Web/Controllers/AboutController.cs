using System.Web.Mvc;

namespace Moon.FrameWork.Web.Controllers
{
    public class AboutController : FrameWorkControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}