using System;
using System.Threading.Tasks;
using Autofac;

namespace Gamification.Infrastructure.CQRS
{
    public class QueryDispatcher: IQueryDispatcher
    {
        private readonly IComponentContext _context;

        public QueryDispatcher(IComponentContext context)
        {
            _context = context;
        }

        public async Task DispatchAsync<T>(T query) where T : IQuery
        {
            if (query == null)
                throw new ArgumentException(nameof(query),
                    $"Command: {typeof(T).Name} can not be null.");

            var handler = _context.Resolve<IQueryHandler<T>>();
            await handler.HandleAsync(query);
        }
    }
}
