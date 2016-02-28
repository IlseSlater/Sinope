using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sinope.Startup))]
namespace Sinope
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
