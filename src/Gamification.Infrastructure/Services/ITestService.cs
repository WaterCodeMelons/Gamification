using System.Collections.Generic;
using System.Threading.Tasks;
using Gamification.Infrastructure.Commands;
using Gamification.Infrastructure.CQRS.Abstract;

namespace Gamification.Infrastructure.Services
{
    public interface ITestService: IService
    {
        Task ChangeState(TestCommand command);
        Task<IEnumerable<string>> GetList();
    }
}
