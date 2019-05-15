using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoLibraryWithSecurity.Startup))]
namespace VideoLibraryWithSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
