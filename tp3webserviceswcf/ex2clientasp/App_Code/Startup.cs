using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ex2clientasp.Startup))]
namespace ex2clientasp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
