using CloudBench.Domain.Exceptions;
using CloudBench.Shared.Enums;

namespace CloudBench.Domain.ValueObjects;

public record ProcessState
{
  public int Id { get; }
  public ProcessId ProcessId { get; }
  public State State { get; }
  public string Label { get; }

  public ProcessState(int id, ProcessId processId, State state, string label)
  {
    if (id <= 0)
      throw new InvalidProcessStateIdException();
    if (string.IsNullOrWhiteSpace(label))
      throw new EmptyCaseStateLabelException();
    Id = id;
    ProcessId = processId;
    State = state;
    Label = label;
  }
}