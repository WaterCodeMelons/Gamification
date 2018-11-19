using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamification.Infrastructure.Commands;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Gamification.API.Controllers
{
    [ApiController]
    [EnableCors("FreePolicy")]
    [Route("api/[controller]")]
    public abstract class ApiBaseController: Controller
    {
        protected ICommandDispatcher CommandDispatcher;

        protected ApiBaseController(ICommandDispatcher commandDispatcher)
        {
            CommandDispatcher = commandDispatcher;
        }
    }
}
