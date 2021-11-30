using CloudBench.Domain.Entities;
using CloudBench.Domain.Repositories;
using CloudBench.Domain.ValueObjects;
using CloudBench.Infrastructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CloudBench.Infrastructure.EF.Repositories;

internal sealed class SqlCaseRepository : ICaseRepository
{
  private readonly WriteDbContext _writeDbContext;
  private readonly DbSet<Case> _cases;

  public SqlCaseRepository(WriteDbContext writeDbContext)
  {
    _cases = writeDbContext.Cases;
    _writeDbContext = writeDbContext;
  }

  public Task<Case> GetAsync(CaseId id)
    => _cases.Include("_notes").SingleOrDefaultAsync(c => c.Id == id);

  public async Task AddAsync(Case @case)
  {
    await _cases.AddAsync(@case);
    await _writeDbContext.SaveChangesAsync();
  }

  public async Task UpdateAsync(Case @case)
  {
    _cases.Update(@case);
    await _writeDbContext.SaveChangesAsync();
  }
}