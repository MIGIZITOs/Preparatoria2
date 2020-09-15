using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Preparatoria2.Startup))]
namespace Preparatoria2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
