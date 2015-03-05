using AppServer.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AppServer.Controllers
{
    /*
    routetest/getbyid
    */

    [Route("RouteTest")]
    public class RouteTestController : Controller
    {
        // GET: /<controller>/
        [Route("GetById")]
        public DataItem GetById()
        {
            return new DataItem { Id = 1, Title = "测试路由" };
        }

        //post
        //RouteTest/add
        [HttpPost]
        [Route("Add")]
        public DataItem Add([FromForm] DataItem dataItem) {
            return dataItem;
        }
    }
}
