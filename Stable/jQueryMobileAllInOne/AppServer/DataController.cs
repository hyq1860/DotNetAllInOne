using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using AppServer.Dao;

namespace AppServer
{
    //http://www.cnblogs.com/r01cn/
    public class DataController : ApiController
    {
        //// GET api/values 
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5 
        public string Get(int id, [FromBody]string value)
        {
            return "value";
        }

        [HttpGet]
        public string Detail(int id, [FromUri]string value)
        {
            return "value";
        }

        // POST api/values 
        public string Post([FromBody]string value)
        {
            return "value";
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }

        public IEnumerable<Product> Get()
        {
            return DataContainer.Products;
        }

        public IEnumerable<Product> GetOrder(int id, string version = "0")
        {
            /*
            MyContext context = new MyContext();
            var empList = context.Persons.OrderBy(c => c.FirstName).ToList();
            Console.WriteLine(empList.Count);
            */

            EcsentryContext productContext = new EcsentryContext();
            var data = productContext.JDCategory.OrderBy(s => s.Id).ToList();
            
            return DataContainer.Products;
        }
    }

    public class DataContainer
    {
        static DataContainer()
        {
            Products = new List<Product>();
            for (int i = 10000; i < 10020; i++)
            {
                Products.Add(new Product()
                {
                    Id=i,
                    Name=string.Format("商品{0}",i),
                    Url = string.Format("http://applite.cn/product/{0}.html", i),
                    Summary = "诺基亚（NOKIA）XL 4G手机（黑色）TD-LTE/TD-SCDMA/GSM诺基亚（NOKIA）XL 4G手机（黑色）TD-LTE/TD-SCDMA/GSM"
                });
            }
        }

        public static List<Product> Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Summary { get; set; }
    }
}
