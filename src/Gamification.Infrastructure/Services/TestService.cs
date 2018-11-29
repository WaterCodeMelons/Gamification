using System.Collections.Generic;
using System.Threading.Tasks;
using Gamification.Infrastructure.Commands;

namespace Gamification.Infrastructure.Services
{
    public class TestService : ITestService
    {
        public async Task ChangeState(TestCommand command)
        {
            command.IsDone = true;
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<string>> GetList()
        {
            return await Task.FromResult<IEnumerable<string>>(new List<string> {"1", "2", "3"});
        }
    }
}
