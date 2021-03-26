using System;
using ACGProjectGoGlobal.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ACGProjectGoGlobal.Web.Controllers
{
    public class HomeController : ACGProjectGoGlobalControllerBase
    {
        public ActionResult Index()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public void Index(UserViewModel model)
        {
            // Store the data in session
            var key = Guid.NewGuid().ToString(); 
            var str = JsonConvert.SerializeObject(model);
            HttpContext.Session.SetString(key, str);

            // Use this to retrieve the value if you want
            var storedValue = HttpContext.Session.GetString(key);
            var obj = JsonConvert.DeserializeObject<UserViewModel>(str);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}