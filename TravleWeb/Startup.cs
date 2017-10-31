using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravleWeb.Startup))]
namespace TravleWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
