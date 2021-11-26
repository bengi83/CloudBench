using CloudBench.Domain.Exceptions;

namespace CloudBench.Domain.ValueObjects;

public class PersonId
{
  public int Value { get; }

  public PersonId(int value)
  {
    if (value <= 0)
      throw new InvalidPersonIdException(value);
    Value = value;
  }

  public static implicit operator int(PersonId id)
    => id.Value;

  public static implicit operator PersonId(int id)
    => new(id);
}