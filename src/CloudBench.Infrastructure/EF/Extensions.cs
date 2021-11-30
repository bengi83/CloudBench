using CloudBench.Domain.Repositories;
using CloudBench.Infrastructure.EF.Contexts;
using CloudBench.Infrastructure.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CloudBench.Infrastructure.EF;

internal static class Extensions
{
  public static IServiceCollection AddSql(this IServiceCollection services, IConfiguration configuration)
  {
    services.AddScoped<ICaseRepository, SqlCaseRepository>();
    
    var connectionString = configuration.GetConnectionString("CloudBenchConnection");
    
    services.AddDbContext<WriteDbContext>(ctx => ctx.UseSqlServer(connectionString));

    return services;
  }
}