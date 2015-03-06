using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace WebAPIBasicAuthentication
{
    public class HTTPBasicAuthorizeAttribute:System.Web.Http.AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization != null)
            {
                string userInfo =
                    Encoding.Default.GetString(
                        Convert.FromBase64String(actionContext.Request.Headers.Authorization.Parameter));
                if (userInfo == string.Format("{0}:{1}", "admin","123456"))
                {
                    IsAuthorized(actionContext);
                }
                else
                {
                    HandleUnauthorizedRequest(actionContext);
                }
            }
            else
            {
                HandleUnauthorizedRequest(actionContext);
            }
        }

        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            var authenticationMessage = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            authenticationMessage.Headers.Add("WWW-Authenticate", "Basic");
            throw new HttpResponseException(authenticationMessage);
        }
    }
}