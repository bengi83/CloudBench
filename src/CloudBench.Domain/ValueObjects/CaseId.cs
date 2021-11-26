using CloudBench.Domain.Exceptions;

namespace CloudBench.Domain.ValueObjects;

public class CaseId
{
  public Guid Value { get; }

  public CaseId(Guid value)
  {
    if (value == Guid.Empty)
      throw new EmptyCaseIdException();
    Value = value;
  }

  public static implicit operator Guid(CaseId id)
    => id.Value;

  public static implicit operator CaseId(Guid id)
    => new(id);
}