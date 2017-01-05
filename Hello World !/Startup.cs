using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hello_World__.Startup))]
namespace Hello_World__
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
