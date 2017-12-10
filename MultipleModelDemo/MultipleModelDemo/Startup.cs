using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultipleModelDemo.Startup))]
namespace MultipleModelDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
