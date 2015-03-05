using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AppServer.Controllers
{
    [Route("[controller]")]
    public class RouteRestfulController : Controller
    {
        // GET: /my/show
        [HttpGet("Show")]
        public IActionResult Show()
        {
            return View();
        }

        // GET: /my
        [HttpGet]
        public IActionResult Get()
        {
            return Content("Get Invoked");
        }

        // POST: /my
        [HttpPost]
        public IActionResult Post()
        {
            return Content("Post Invoked");
        }

        // POST: /my/stuff
        [HttpPost("Stuff")]
        public IActionResult Post([FromBody]string firstName)
        {
            return Content("Post Stuff Invoked");
        }
    }
}
