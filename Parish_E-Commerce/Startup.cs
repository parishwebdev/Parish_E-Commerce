using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Parish_E_Commerce.Startup))]
namespace Parish_E_Commerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
