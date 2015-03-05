using AppServer.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AppServer.Controllers
{
    [Route("api/[controller]")]
    public class RouteWebApiController : Controller
    {
        //get
        //api/routewebapi
        public string Get()
        {
            return "webapi route";
        }

        //get
        //api/routewebapi/123
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "webapi route " + id;
        }

        //post
        //api/routewebapi/
        //postman form-data
        [HttpPost]
        public string Post([FromForm]DataItem value)
        {
            //var data = Request.ContentType;
            var data = new JsonResult("");
            
            return "1234";
        }
    }
}
