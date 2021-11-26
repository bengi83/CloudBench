using CloudBench.Shared;

namespace CloudBench.Domain.Exceptions;

public class InvalidProcessIdException : CloudBenchException
{
  public InvalidProcessIdException()
    : base("Process ID must be a positive, non-zero number.")
  {
  }
}