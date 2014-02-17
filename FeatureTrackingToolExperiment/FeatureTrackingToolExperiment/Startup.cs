using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FeatureTrackingToolExperiment.Startup))]
namespace FeatureTrackingToolExperiment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
