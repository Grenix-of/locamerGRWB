using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(locamerguu.Startup))]
namespace locamerguu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
