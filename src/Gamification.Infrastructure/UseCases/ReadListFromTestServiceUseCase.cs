using System.Collections.Generic;
using System.Threading.Tasks;
using Gamification.Infrastructure.CQRS.Abstract;
using Gamification.Infrastructure.Queries;
using Gamification.Infrastructure.Services;

namespace Gamification.Infrastructure.UseCases
{
    public class ReadListFromTestServiceUseCase : IQueryHandler<TestQuery, IEnumerable<string>>
    {
        private ITestService _testService;

        public ReadListFromTestServiceUseCase(ITestService testService)
        {
            _testService = testService;
        }

        public async Task<IEnumerable<string>> HandleAsync(TestQuery query)
        {
            return await _testService.GetList();
        }
    }
}
