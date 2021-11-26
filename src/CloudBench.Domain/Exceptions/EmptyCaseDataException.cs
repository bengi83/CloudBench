using CloudBench.Shared;

namespace CloudBench.Domain.Exceptions;

public class EmptyCaseDataException : CloudBenchException
{
  public EmptyCaseDataException()
    : base("Case data cannot be empty.")
  {
  }
}