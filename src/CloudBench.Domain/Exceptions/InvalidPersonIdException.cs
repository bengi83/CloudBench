using CloudBench.Shared;

namespace CloudBench.Domain.Exceptions;

public class InvalidPersonIdException : CloudBenchException
{
  public InvalidPersonIdException(int id)
    : base($"Person Id must be a positive, non-zero number.")
  {
  }
}