using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prova1.Startup))]
namespace prova1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
