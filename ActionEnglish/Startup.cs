using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ActionEnglish.Startup))]
namespace ActionEnglish
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
