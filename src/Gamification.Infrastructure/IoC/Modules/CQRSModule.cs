using System.Reflection;
using Autofac;
using Gamification.Infrastructure.CQRS;

namespace Gamification.Infrastructure.IoC.Modules
{
    public class CQRSModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(CQRSModule)
                .GetTypeInfo()
                .Assembly;

            builder.RegisterType<CommandDispatcher>()
                .As<ICommandDispatcher>()
                .InstancePerLifetimeScope();

            builder.RegisterType<QueryDispatcher>()
                .As<IQueryDispatcher>()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(ICommandHandler<>))
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(IQueryHandler<>))
                .InstancePerLifetimeScope();
        }
    }
}