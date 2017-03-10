using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineAccountBook.Startup))]
namespace OnlineAccountBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
