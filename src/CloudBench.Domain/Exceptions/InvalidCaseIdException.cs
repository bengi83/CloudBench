using CloudBench.Shared;

namespace CloudBench.Domain.Exceptions;

public class InvalidCaseIdException : CloudBenchException
{
  public InvalidCaseIdException()
    : base("Case Id must be a positive, non-zero number.")
  {
  }
}