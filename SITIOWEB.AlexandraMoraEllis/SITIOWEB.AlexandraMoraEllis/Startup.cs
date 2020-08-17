using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SITIOWEB.AlexandraMoraEllis.Startup))]
namespace SITIOWEB.AlexandraMoraEllis
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
