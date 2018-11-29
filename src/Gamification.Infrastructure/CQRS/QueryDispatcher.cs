using System.Threading.Tasks;
using Autofac;
using Gamification.Infrastructure.CQRS.Abstract;

namespace Gamification.Infrastructure.CQRS
{
    public class QueryDispatcher: IQueryDispatcher
    {
        private readonly IComponentContext _context;

        public QueryDispatcher(IComponentContext context)
        {
            _context = context;
        }

        public async Task<TResult> DispatchAsync<TResult>(IQuery<TResult> query)
        {
            {
                var handlerType = typeof(IQueryHandler<,>)
                    .MakeGenericType(query.GetType(), typeof(TResult));

                dynamic handler = _context.Resolve(handlerType);

                return await handler.HandleAsync((dynamic)query);
            }
        }
    }
}
