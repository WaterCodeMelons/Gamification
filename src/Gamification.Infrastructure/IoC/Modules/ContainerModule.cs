using Autofac;
using Microsoft.Extensions.Configuration;


namespace Gamification.Infrastructure.IoC.Modules
{
    public class ContainerModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;

        public ContainerModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CQRSModule>();
            builder.RegisterModule<ServiceModule>();
        }
    }
}