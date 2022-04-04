using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CWM_VidlyGyak.Startup))]
namespace CWM_VidlyGyak
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
