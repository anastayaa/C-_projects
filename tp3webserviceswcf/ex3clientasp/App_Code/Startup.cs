using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ex3clientasp.Startup))]
namespace ex3clientasp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
