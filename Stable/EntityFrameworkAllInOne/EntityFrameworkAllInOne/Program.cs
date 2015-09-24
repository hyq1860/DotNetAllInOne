using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNet.Data;

namespace EntityFrameworkAllInOne
{
    class Program
    {
        static void Main(string[] args)
        {
            StockRepository stockRepository = new StockRepository(new EntityFrameworkDbContext("MySqlConnectionString"), true);

            stockRepository.Add(new Stock() { Name = "haha" });
        }
    }
}
