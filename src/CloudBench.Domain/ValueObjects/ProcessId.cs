using CloudBench.Domain.Exceptions;

namespace CloudBench.Domain.ValueObjects;

public class ProcessId
{
  public int Value { get; }

  public ProcessId(int value)
  {
    if (value <= 0)
      throw new InvalidProcessIdException();
    Value = value;
  }

  public static implicit operator int(ProcessId id)
    => id.Value;

  public static implicit operator ProcessId(int id)
    => new(id);
}