using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VMedStore.Startup))]
namespace VMedStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
