using System.Collections.Generic;
using System.Threading.Tasks;
using Gamification.Infrastructure.Commands;
using Gamification.Infrastructure.CQRS;
using Gamification.Infrastructure.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Gamification.API.Controllers
{
    public class TestController : ApiBaseController
    {
        public TestController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
            : base(commandDispatcher, queryDispatcher)
        {
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TestCommand command)
        {
            await CommandDispatcher.DispatchAsync(command);
            return Created($"{command.IsDone}", new object());
        }

        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            return await QueryDispatcher.DispatchAsync(new TestQuery());
        }
    }
}
