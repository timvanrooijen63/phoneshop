using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoneShop.Startup))]
namespace PhoneShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
