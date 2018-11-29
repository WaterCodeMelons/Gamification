using System.Threading.Tasks;

namespace Gamification.Infrastructure.CQRS.Abstract
{
    public interface IQueryHandler<TQuery, TResult> where TQuery: IQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query);
    }
}
