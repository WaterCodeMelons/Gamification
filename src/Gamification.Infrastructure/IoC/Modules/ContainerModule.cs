using Autofac;
using Microsoft.Extensions.Configuration;

namespace Gamification.Infrastructure.IoC.Modules
{
    public class ContainerModule : Module
    {
        private IConfiguration configuration;

        public ContainerModule(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CommandModule>();
        }
    }
}