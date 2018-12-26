using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactPro.Startup))]
namespace ContactPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
