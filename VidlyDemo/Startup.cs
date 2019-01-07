using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyDemo.Startup))]
namespace VidlyDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
