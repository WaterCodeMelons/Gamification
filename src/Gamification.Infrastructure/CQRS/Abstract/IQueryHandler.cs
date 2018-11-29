using System.Threading.Tasks;

namespace Gamification.Infrastructure.CQRS
{
    public interface IQueryHandler<T> where T: IQuery
    {
        Task HandleAsync(T query);
    }
}
