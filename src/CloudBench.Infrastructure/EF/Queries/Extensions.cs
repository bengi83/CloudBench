using CloudBench.Application.DTO;
using CloudBench.Infrastructure.EF.Models;

namespace CloudBench.Infrastructure.EF.Queries;

internal static class Extensions
{
  public static CaseDto AsDto(this CaseReadModel readModel)
    => new()
    {
      Id = readModel.Id
    };
}