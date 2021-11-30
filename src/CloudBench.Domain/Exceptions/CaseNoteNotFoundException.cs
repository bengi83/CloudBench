using CloudBench.Shared;

namespace CloudBench.Domain.Exceptions;

public class CaseNoteNotFoundException : CloudBenchException
{
  public CaseNoteNotFoundException(Guid id)
    : base($"Case note not found '{id}'")
  {
  }
}