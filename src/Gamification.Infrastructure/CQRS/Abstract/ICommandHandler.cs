using System.Threading.Tasks;

namespace Gamification.Infrastructure.CQRS
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}