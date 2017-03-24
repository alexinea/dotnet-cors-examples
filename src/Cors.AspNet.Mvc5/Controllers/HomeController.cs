using System.Web.Mvc;
using Cors.AspNet.Mvc5.Attributes;

namespace Cors.AspNet.Mvc5.Controllers
{
    [AllowCrossSiteJson]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Json("ok, mvc5", JsonRequestBehavior.AllowGet);
        }
    }
}