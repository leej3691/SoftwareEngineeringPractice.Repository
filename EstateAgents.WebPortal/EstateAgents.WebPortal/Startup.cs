using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstateAgents.WebPortal.Startup))]
namespace EstateAgents.WebPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
