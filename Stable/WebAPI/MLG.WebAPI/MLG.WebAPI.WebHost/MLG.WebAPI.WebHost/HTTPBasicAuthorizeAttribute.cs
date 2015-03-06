using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MLG.WebAPI.WebHost
{
    public class HTTPBasicAuthorizeAttribute : System.Web.Http.AuthorizeAttribute
    {
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            //判断用户是否登录
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
                HandleUnauthorizedRequest(actionContext);
        }
        protected override void HandleUnauthorizedRequest(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            var challengeMessage = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            challengeMessage.Headers.Add("WWW-Authenticate", "Basic");
            throw new System.Web.Http.HttpResponseException(challengeMessage);
        }

    }
}