using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartFoodOrdering.Startup))]
namespace SmartFoodOrdering
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
