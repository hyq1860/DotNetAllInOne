using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(FormCollection fol)
        {
            if (Request.HttpMethod.Equals("POST", StringComparison.OrdinalIgnoreCase))
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie(fol["username"], false);
                return Redirect("/api/Users");
            }
            
            return View();
        }
    }
}
