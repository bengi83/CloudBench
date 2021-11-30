using CloudBench.Shared;

namespace CloudBench.Infrastructure.Exceptions;

public class NextIdBatchUnavailableException : CloudBenchException
{
  public NextIdBatchUnavailableException(string entityTypeName)
    : base($"Failed to get next Id batch for entity type '{entityTypeName}'")
  {
  }
}