using Core.Interfaces.Patterns;
using Core.Models;
using System.Linq;

namespace Core.Workflow.Contracts
{
    public interface IWorkflow : ICommandAsync<AggregateResult>
    {
        IOrderedEnumerable<IWorkflowStep> Steps { get; }


    }
}
