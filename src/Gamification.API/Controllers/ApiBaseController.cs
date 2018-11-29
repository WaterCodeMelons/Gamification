using Gamification.Infrastructure.CQRS;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Gamification.API.Controllers
{
    [ApiController]
    [EnableCors("FreePolicy")]
    [Route("api/[controller]")]
    public abstract class ApiBaseController : Controller
    {
        protected ICommandDispatcher CommandDispatcher;
        protected IQueryDispatcher QueryDispatcher;

        protected ApiBaseController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            CommandDispatcher = commandDispatcher;
            QueryDispatcher = queryDispatcher;
        }
    }
}