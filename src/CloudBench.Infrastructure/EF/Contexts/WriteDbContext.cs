using CloudBench.Domain.Entities;
using CloudBench.Domain.ValueObjects;
using CloudBench.Infrastructure.EF.Config;
using Microsoft.EntityFrameworkCore;

namespace CloudBench.Infrastructure.EF.Contexts;

public class WriteDbContext : DbContext
{
  public DbSet<Case> Cases { get; set; }

  public WriteDbContext(DbContextOptions<WriteDbContext> options)
    : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.HasDefaultSchema("dbo");

    var configuration = new WriteConfiguration();
    modelBuilder.ApplyConfiguration<Case>(configuration);
    modelBuilder.ApplyConfiguration<CaseNote>(configuration);
  }
}