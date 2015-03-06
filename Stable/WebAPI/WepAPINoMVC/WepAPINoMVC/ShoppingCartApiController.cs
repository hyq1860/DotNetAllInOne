using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WepAPINoMVC
{
    public class ShoppingCartApiController : ApiController
    {
        public string GetCartId()
        {
            return System.Guid.NewGuid().ToString();
        }
    }
}