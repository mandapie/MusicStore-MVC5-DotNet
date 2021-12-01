using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicStore_MVC5_DotNet.Startup))]
namespace MusicStore_MVC5_DotNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
