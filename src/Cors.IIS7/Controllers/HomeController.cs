using System.Web.Mvc;

namespace Cors.IIS7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Json("ok, iis7");
        }
    }
}