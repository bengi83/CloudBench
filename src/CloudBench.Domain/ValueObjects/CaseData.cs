using CloudBench.Domain.Exceptions;

namespace CloudBench.Domain.ValueObjects;

public class CaseData
{
  public byte[] Value;

  public CaseData(byte[] value)
  {
    if (value.Length == 0)
      throw new EmptyCaseDataException();
    Value = value;
  }

  private CaseData()
  {
    Value = Array.Empty<byte>();
  }

  public bool HasData => Value.Length > 0;
  
  public static CaseData Empty()
  {
    return new CaseData();
  }

  public static implicit operator byte[](CaseData data)
    => data.Value;

  public static implicit operator CaseData(byte[] data)
    => new(data);
}