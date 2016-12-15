using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopWebForms.Startup))]
namespace ShopWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
