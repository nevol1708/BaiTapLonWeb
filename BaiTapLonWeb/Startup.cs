using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaiTapLonWeb.Startup))]
namespace BaiTapLonWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
