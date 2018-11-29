using System.Threading.Tasks;
using Gamification.Infrastructure.Commands;
using Gamification.Infrastructure.CQRS;
using Gamification.Infrastructure.Services;

namespace Gamification.Infrastructure.UseCases
{
    public class ProcessingTestCommandUseCase : ICommandHandler<TestCommand>
    {
        private readonly ITestService _testService;

        public ProcessingTestCommandUseCase(ITestService testService)
        {
            _testService = testService;
        }

        public async Task HandleAsync(TestCommand command)
        {
            await _testService.ChangeState(command);
        }
    }
}
