using System.Web.Mvc;

namespace Cors.AspNet.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("ok, webapi home");
        }
    }
}
