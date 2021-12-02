using CloudBench.Application.DTO;
using CloudBench.Shared.Abstractions.Queries;

namespace CloudBench.Application.Queries;

public class GetCase : IQuery<CaseDto>
{
  public int Id { get; set; }
}