using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Carli.Startup))]
namespace Carli
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
