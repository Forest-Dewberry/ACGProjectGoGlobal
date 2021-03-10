using Microsoft.AspNetCore.Mvc;

namespace ACGProjectGoGlobal.Web.Controllers
{
    public class HomeController : ACGProjectGoGlobalControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}