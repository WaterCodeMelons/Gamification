using System.Collections.Generic;
using Gamification.Infrastructure.CQRS;

namespace Gamification.Infrastructure.Queries
{
    public class TestQuery: IQuery<IEnumerable<string>>
    {
    }
}
