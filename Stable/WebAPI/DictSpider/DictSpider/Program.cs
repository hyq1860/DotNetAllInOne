using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictSpider
{
    class Program
    {
        static void Main(string[] args)
        {
            YouDaoDictSpider youDaoDictSpider=new YouDaoDictSpider();
            //youDaoDictSpider.Spider();
            youDaoDictSpider.MainSpider();
        }
    }
}
