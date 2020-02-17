using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstateAgents.CMS.Startup))]
namespace EstateAgents.CMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
