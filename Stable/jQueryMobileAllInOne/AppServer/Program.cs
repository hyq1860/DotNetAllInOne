using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace AppServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = string.Format("http://{0}:5001/", GetServerLocalIp());

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine(string.Format("Server running at {0}", baseAddress));
                Console.ReadLine();
            }
        }

        static string GetServerLocalIp()
        {
            string hostname = Dns.GetHostName();
            IPHostEntry localhost = Dns.GetHostByName(hostname);
            IPAddress localaddr = localhost.AddressList[0];
            return "127.0.0.1";
            //return localaddr.ToString();
        }
    }
}
