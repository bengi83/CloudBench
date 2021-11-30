using CloudBench.Domain.Exceptions;

namespace CloudBench.Domain.ValueObjects;

public class CaseId
{
  public int Value { get; }

  public CaseId(int value)
  {
    if (value <= 0)
      throw new InvalidCaseIdException();
    Value = value;
  }

  public static implicit operator int(CaseId id)
    => id.Value;

  public static implicit operator CaseId(int id)
    => new(id);
}