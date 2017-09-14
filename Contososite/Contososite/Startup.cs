using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contososite.Startup))]
namespace Contososite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
