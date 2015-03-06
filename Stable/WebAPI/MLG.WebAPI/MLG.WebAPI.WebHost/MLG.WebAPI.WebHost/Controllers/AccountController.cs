using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using System.Web.Security;
using MLG.WebAPI.WebHost.Models;

namespace MLG.WebAPI.WebHost.Controllers
{
    public class AccountController : Controller
    {
        static Dictionary<string, string> userAccounts;

        static AccountController()
        {
            userAccounts = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            userAccounts.Add("1", "1");
            userAccounts.Add("2", "2");
            userAccounts.Add("3", "3");
        }
        public ActionResult Login()
        {
            return View(new Credential());
        }

        [HttpPost]
        public ActionResult Login(Credential loginInfo, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            string password;
            if (userAccounts.TryGetValue(loginInfo.UserName, out password))
            {
                if (password == loginInfo.Password)
                {
                    FormsAuthentication.SetAuthCookie(loginInfo.UserName, false);
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        return new HttpStatusCodeResult(HttpStatusCode.OK);
                    }
                    return Redirect(returnUrl);
                }
                ModelState.AddModelError("Password", "密码不正确");
            }
            else
            {
                ModelState.AddModelError("UserName", "用户名不存在");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection fol)
        {
            ///此处为了演示简化登录过程
            ///可以在此处扩展验证用户名或者密码是否正确
            System.Web.Security.FormsAuthentication.SetAuthCookie(fol["username"], false);
            return Redirect("/HTMLPage5.htm");
        }
    }
}
