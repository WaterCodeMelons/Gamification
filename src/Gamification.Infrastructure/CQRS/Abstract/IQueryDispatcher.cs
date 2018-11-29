using System.Threading.Tasks;
using Gamification.Infrastructure.Commands;

namespace Gamification.Infrastructure.CQRS
{
    public interface IQueryDispatcher
    {
        Task DispatchAsync<T>(T query) where T : IQuery;
    }
}
