using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstateAgents.IMS.Startup))]
namespace EstateAgents.IMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
