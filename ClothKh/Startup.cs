using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothKh.Startup))]
namespace ClothKh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
