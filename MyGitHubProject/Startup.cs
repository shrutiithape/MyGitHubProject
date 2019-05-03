using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGitHubProject.Startup))]
namespace MyGitHubProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
