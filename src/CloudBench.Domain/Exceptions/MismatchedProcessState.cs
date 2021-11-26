using CloudBench.Domain.ValueObjects;
using CloudBench.Shared;

namespace CloudBench.Domain.Exceptions;

public class MismatchedProcessState : CloudBenchException
{
  public MismatchedProcessState(ProcessState newState, ProcessId processId)
    : base($"Unable to assign state (ID: {newState.Id}) to process (ID: {processId})")
  {
  }
}