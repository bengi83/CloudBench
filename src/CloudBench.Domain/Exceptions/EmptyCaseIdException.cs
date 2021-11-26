using CloudBench.Shared;

namespace CloudBench.Domain.Exceptions;

public class EmptyCaseIdException : CloudBenchException
{
  public EmptyCaseIdException()
    : base("Case Id cannot be empty.")
  {
  }
}