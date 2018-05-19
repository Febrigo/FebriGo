using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FebriGo.Startup))]
namespace FebriGo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
