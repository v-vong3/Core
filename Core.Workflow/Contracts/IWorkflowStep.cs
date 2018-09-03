using Core.Interfaces.Patterns;
using Core.Models;

namespace Core.Workflow.Contracts
{
    public interface IWorkflowStep : ICommandAsync<Result>
    {
        string StepName { get; }

        int Order { get; }


    }
}
