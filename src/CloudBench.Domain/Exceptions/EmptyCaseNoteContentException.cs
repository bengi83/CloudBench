using CloudBench.Shared;

namespace CloudBench.Domain.Exceptions;

public class EmptyCaseNoteContentException : CloudBenchException
{
  public EmptyCaseNoteContentException()
    : base("Case note content cannot be empty.")
  {
  }
}