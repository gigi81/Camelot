using System.Linq;
using Camelot.Services.Abstractions.Models.Enums;

namespace Camelot.Services.Abstractions.Extensions
{
    public static class OperationStateExtensions
    {
        public static bool IsCompleted(this OperationState operationState)
        {
            var completedOperationStates = new[]
            {
                OperationState.Failed, OperationState.Cancelled, OperationState.Finished
            };

            return completedOperationStates.Contains(operationState);
        }

        public static bool IsCancellationAvailable(this OperationState operationState)
        {
            var cancellableOperationStates = new[]
            {
                OperationState.InProgress,
                OperationState.Paused,
                OperationState.Blocked
            };

            return cancellableOperationStates.Contains(operationState);
        }
    }
}