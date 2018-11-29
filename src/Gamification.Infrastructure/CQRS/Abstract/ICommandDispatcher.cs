using System.Threading.Tasks;

namespace Gamification.Infrastructure.CQRS
{
    public interface ICommandDispatcher
    {
        Task DispatchAsync<T>(T command) where T : ICommand;
    }
}