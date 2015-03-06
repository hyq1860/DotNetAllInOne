using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MLG.WebAPI.WebHost.Controllers
{
    [CustomAuthorize]
    public class DemoController : ApiController
    {
        public IEnumerable<string> GetUsers()
        {
            yield return HttpContext.Current.User.Identity.Name+"\n";
            yield return Thread.CurrentPrincipal.Identity.Name+"\n";
            yield return this.User.Identity.Name+"\n";
        }

        
        public IEnumerable<String> Index()
        {
            return new List<string>() {"1", "2", "3"};
        } 
    }
}
