using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doan_Shoponline.Startup))]
namespace Doan_Shoponline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
