namespace CloudBench.Shared;

public class CloudBenchException : Exception
{
  public CloudBenchException(string message)
    : base(message)
  {
  }
}