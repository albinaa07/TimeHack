using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Timehack.Startup))]
namespace Timehack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
