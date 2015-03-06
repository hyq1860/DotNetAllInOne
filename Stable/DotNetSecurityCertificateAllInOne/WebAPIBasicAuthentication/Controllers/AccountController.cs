using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIBasicAuthentication.Controllers
{
    [HTTPBasicAuthorize]
    public class AccountController : ApiController
    {
        [HttpGet]
        public string Index()
        {
            return "Index";
        }
    }
}
