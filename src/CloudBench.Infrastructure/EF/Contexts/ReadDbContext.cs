using CloudBench.Application.DTO;
using CloudBench.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudBench.Infrastructure.EF.Contexts;

internal sealed class ReadDbContext : DbContext
{
  public DbSet<CaseReadModel> Cases { get; set; }
  public DbSet<IdBatchReadModel> IdBatches { get; set; }

  public ReadDbContext(DbContextOptions<ReadDbContext> options)
    : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    
  }
}