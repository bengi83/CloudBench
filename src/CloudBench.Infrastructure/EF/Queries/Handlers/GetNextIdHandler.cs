using CloudBench.Application.Queries;
using CloudBench.Infrastructure.EF.Contexts;
using CloudBench.Infrastructure.EF.Models;
using CloudBench.Infrastructure.Exceptions;
using CloudBench.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace CloudBench.Infrastructure.EF.Queries.Handlers;

internal sealed class GetNextIdHandler : IQueryHandler<GetNextId, int>
{
  private static readonly Dictionary<string, IdBatchState> _batches = new();

  private readonly ReadDbContext _context;

  public GetNextIdHandler(ReadDbContext context)
  {
    _context = context;
  }

  public async Task<int> HandleAsync(GetNextId query)
  {
    IdBatchState batch = default;
    if (_batches.ContainsKey(query.EntityTypeName))
      batch = _batches[query.EntityTypeName];

    if (batch.Value < batch.BatchStart + batch.BatchSize)
    {
      _batches[query.EntityTypeName] = batch with
      {
        Value = batch.Value + 1
      };
      return batch.Value;
    }

    var nextBatch = await _context.IdBatches
      .FromSqlInterpolated($"")
      .AsNoTracking()
      .FirstOrDefaultAsync();

    if (nextBatch is null || nextBatch.BatchSize < 1 || nextBatch.BatchStart < 1)
      throw new NextIdBatchUnavailableException(query.EntityTypeName);

    batch = new IdBatchState(nextBatch.BatchStart, nextBatch.BatchSize, nextBatch.BatchStart);
    _batches[query.EntityTypeName] = batch;

    return batch.Value;
  }
}