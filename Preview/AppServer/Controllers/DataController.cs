using AppServer.Models;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860
//http://stephenwalther.com/archive/2015/02/07/asp-net-5-deep-dive-routing
//https://github.com/aspnet/Home 官方的学习asp.net5
namespace AppServer.Controllers
{
    //[Route("api/[controller]")]
    public class DataController : Controller
    {

        static readonly List<DataItem> _items = new List<DataItem>()
        {
            new DataItem { Id = 1, Title = "First Item1111" },
            new DataItem { Id = 2, Title = "第二个111111111111111" }
        };

        //[HttpGet]
        public IEnumerable<DataItem> GetAll()
        {
            return _items;
        }

        //[HttpGet("{id:int}", Name = "GetByIdRoute")]
        public IActionResult GetById(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return HttpNotFound();
            }

            return new ObjectResult(item);
        }

        //[HttpPost(Name = "CreateTodoItem")]
        public DataItem CreateTodoItem([FromForm] DataItem item)
        {
            return item;
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                item.Id = 1 + _items.Max(x => (int?)x.Id) ?? 0;
                _items.Add(item);
                string url = Url.RouteUrl("GetByIdRoute", new { id = item.Id },Request.Scheme, Request.Host.ToUriComponent());

                Context.Response.StatusCode = 201;
                Context.Response.Headers["Location"] = url;
            }
        }

        //[HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {

            var item = _items.FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                return HttpNotFound();

            }
            _items.Remove(item);

            return new HttpStatusCodeResult(204); // 201 No Content
        }
    }

}
