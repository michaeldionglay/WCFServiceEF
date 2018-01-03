using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhysicianDirectoryCheckpoint.Startup))]
namespace PhysicianDirectoryCheckpoint
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
