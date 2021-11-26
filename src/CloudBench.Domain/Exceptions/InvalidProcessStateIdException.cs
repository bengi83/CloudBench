using CloudBench.Shared;

namespace CloudBench.Domain.Exceptions;

public class InvalidProcessStateIdException : CloudBenchException
{
  public InvalidProcessStateIdException() 
    : base("Process state ID must be a positive, non-zero number.")
  {
  }
}