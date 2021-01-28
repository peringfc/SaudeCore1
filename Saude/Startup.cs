using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Saude.Startup))]
namespace Saude
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
