using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using Owin.WebSocket.Extensions;

namespace AppServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
            //只返回json
            //config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            config.Formatters.XmlFormatter.UseXmlSerializer = false;
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = true;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            

            // 跨域支持
            appBuilder.UseCors(CorsOptions.AllowAll);

            //signalr
            //appBuilder.MapSignalR();
            
            appBuilder.UseWebApi(config);

            #region websocket
            //For static routes 'http://foo.com/ws' use MapWebSocketRoute
            //appBuilder.MapWebSocketRoute<AppWebSocket>("/ws");

            //For dynamic routes where you may want to capture the URI arguments use a Regex route
            //appBuilder.MapWebSocketPattern<AppWebSocket>("/captures/(?<capture1>.+)/(?<capture2>.+)");
            #endregion
        }
    } 
}
