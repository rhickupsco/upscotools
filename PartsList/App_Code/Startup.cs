using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartsList.Startup))]
namespace PartsList
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
