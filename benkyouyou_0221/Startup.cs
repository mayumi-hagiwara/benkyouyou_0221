using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(benkyouyou_0221.Startup))]
namespace benkyouyou_0221
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
