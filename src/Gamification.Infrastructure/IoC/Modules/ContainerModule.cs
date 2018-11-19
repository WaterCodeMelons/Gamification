using Autofac;
using Microsoft.Extensions.Configuration;

namespace Gamification.Infrastructure.IoC.Modules
{
    public class ContainerModule : Autofac.Module
    {
        private IConfiguration _configuration;

        public ContainerModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CommandModule>();
        }
    }
}