using CloudBench.Shared.Abstractions.Queries;

namespace CloudBench.Application.Queries;

public class GetNextId : IQuery<int>
{
  public string EntityTypeName { get; set; }
}