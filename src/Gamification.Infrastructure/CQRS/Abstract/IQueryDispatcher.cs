using System.Threading.Tasks;
using Gamification.Infrastructure.Commands;

namespace Gamification.Infrastructure.CQRS
{
    public interface IQueryDispatcher
    {
        Task<TResult> DispatchAsync<TResult>(IQuery<TResult> query);
    }
}
