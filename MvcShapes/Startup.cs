using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcShapes.Startup))]
namespace MvcShapes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
