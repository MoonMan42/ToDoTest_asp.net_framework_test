using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoTest.Startup))]
namespace ToDoTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
