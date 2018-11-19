using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Microsoft.Extensions.Configuration;

namespace Gamification.Infrastructure.IoC.Modules
{
    public class ContainerModule : Autofac.Module
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
