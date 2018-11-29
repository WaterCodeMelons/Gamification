using System.Collections;
using System.Collections.Generic;
using Gamification.Infrastructure.CQRS;

namespace Gamification.Infrastructure.Commands
{
    public class TestCommand : ICommand
    {
        public bool IsDone { get; set; }
        public IEnumerable<string> List { get; set; }
    }
}
