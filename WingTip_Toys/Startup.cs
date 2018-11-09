using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WingTip_Toys.Startup))]
namespace WingTip_Toys
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
