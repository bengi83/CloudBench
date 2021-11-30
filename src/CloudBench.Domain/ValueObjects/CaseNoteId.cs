using System.Reflection.Metadata.Ecma335;
using CloudBench.Domain.Exceptions;

namespace CloudBench.Domain.ValueObjects;

public class CaseNoteId : IEquatable<Guid>, IEquatable<CaseNoteId>
{
  public Guid Value { get; }

  public CaseNoteId(Guid value)
  {
    if (value == Guid.Empty)
      throw new EmptyCaseNoteIdException();
    Value = value;
  }

  public static implicit operator Guid(CaseNoteId id)
    => id.Value;
  
  public static implicit operator CaseNoteId(Guid id)
    => new (id);

  public static bool operator ==(CaseNoteId lhs, CaseNoteId rhs)
    => lhs.Value == rhs.Value;
  
  public static bool operator !=(CaseNoteId lhs, CaseNoteId rhs)
    => lhs.Value != rhs.Value;
  
  public static bool operator ==(CaseNoteId lhs, Guid rhs)
    => lhs.Value == rhs;
  
  public static bool operator !=(CaseNoteId lhs, Guid rhs)
    => lhs.Value != rhs;
  
  public static bool operator ==(Guid lhs, CaseNoteId rhs)
    => lhs == rhs.Value;
  
  public static bool operator !=(Guid lhs, CaseNoteId rhs)
    => lhs != rhs.Value;

  public bool Equals(Guid other)
    => Value.Equals(other);

  public bool Equals(CaseNoteId other)
    => Value.Equals(other.Value);

  public override bool Equals(object? obj)
  {
    if (ReferenceEquals(null, obj)) return false;
    if (obj is CaseNoteId caseNoteId && Value == caseNoteId.Value) return true;
    if (obj is Guid guid && Value == guid) return true;
    return false;
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}