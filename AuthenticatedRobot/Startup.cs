using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthenticatedRobot.Startup))]
namespace AuthenticatedRobot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
