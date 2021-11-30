using CloudBench.Shared;

namespace CloudBench.Application.Exceptions;

public class CaseNotFoundException : CloudBenchException
{
  public CaseNotFoundException(int caseId)
    : base($"Unable to find case by Id '{caseId}'.")
  {
  }
}