using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHubNerd.Startup))]
namespace GigHubNerd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
