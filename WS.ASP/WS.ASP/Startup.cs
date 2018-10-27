using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WS.ASP.Startup))]
namespace WS.ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
