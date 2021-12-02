using CloudBench.Application.DTO;
using CloudBench.Application.Queries;
using CloudBench.Infrastructure.EF.Contexts;
using CloudBench.Infrastructure.EF.Models;
using CloudBench.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace CloudBench.Infrastructure.EF.Queries.Handlers;

internal sealed class GetCaseHandler : IQueryHandler<GetCase, CaseDto>
{
  private readonly DbSet<CaseReadModel> _cases;

  public GetCaseHandler(ReadDbContext context)
    => _cases = context.Cases;

  public Task<CaseDto> HandleAsync(GetCase query)
    => _cases
      .Where(c => c.Id == query.Id)
      .Select(c => c.AsDto())
      .AsNoTracking()
      .SingleOrDefaultAsync();
}