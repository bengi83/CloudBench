using CloudBench.Shared;

namespace CloudBench.Domain.Exceptions;

public class EmptyCaseStateLabelException : CloudBenchException
{
  public EmptyCaseStateLabelException()
    : base("Case state label cannot be empty.")
  {
  }
}