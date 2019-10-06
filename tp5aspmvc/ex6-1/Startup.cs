using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ex7.Startup))]
namespace ex7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
