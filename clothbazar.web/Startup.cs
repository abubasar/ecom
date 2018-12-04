using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(clothbazar.web.Startup))]
namespace clothbazar.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
