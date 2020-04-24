using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalWebRTC.Startup))]
namespace FinalWebRTC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
