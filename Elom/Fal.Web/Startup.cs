using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fal.Web.Startup))]
namespace Fal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
