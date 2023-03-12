using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThachTrungHieu_2011064233.Startup))]
namespace ThachTrungHieu_2011064233
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
