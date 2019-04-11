using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodOutlet.Startup))]
namespace FoodOutlet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
