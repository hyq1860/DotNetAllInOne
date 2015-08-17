using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RazorEngineWebDemo.Startup))]
namespace RazorEngineWebDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
