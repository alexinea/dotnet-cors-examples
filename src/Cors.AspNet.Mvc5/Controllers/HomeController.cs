using System.Web.Mvc;
using Cors.AspNet.Mvc5.Attributes;

namespace Cors.AspNet.Mvc5.Controllers
{
    [AllowCrossSite]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Json("ok, mvc5", JsonRequestBehavior.AllowGet);
        }

        public ActionResult Html()
        {
            return Content("ok mvc5 content");
        }
    }
}