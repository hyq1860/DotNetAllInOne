using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace AppServer
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //mvc支持
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            //启用欢迎界面
            //app.UseWelcomePage();

            // Add static files to the request pipeline.


            // Add cookie-based authentication to the request pipeline.

            //添加 MVC 6 到管道
            app.UseMvc(routes=> {
                // route1
                routes.MapRoute(
                    name: "route1",
                    template: "super",
                    defaults: new { controller = "Data", action = "GetAll" }
                );
            });
        }
    }
}
