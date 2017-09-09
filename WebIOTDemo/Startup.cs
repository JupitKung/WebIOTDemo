using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebIOTDemo.Startup))]
namespace WebIOTDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
