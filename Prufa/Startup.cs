using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prufa.Startup))]
namespace Prufa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
