using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UPSCOApplicationServiceCenter.Startup))]
namespace UPSCOApplicationServiceCenter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
