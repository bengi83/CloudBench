using CloudBench.Shared;

namespace CloudBench.Domain.Exceptions;

public class EmptyCaseNoteIdException : CloudBenchException
{
  public EmptyCaseNoteIdException() 
    : base("Case note Id must not be empty.")
  {
  }
}