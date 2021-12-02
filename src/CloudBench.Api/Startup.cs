using Microsoft.OpenApi.Models;

namespace CloudBench.Api;

public class Startup
{
  public Startup(IConfiguration configuration)
  {
    Configuration = configuration;
  }

  public IConfiguration Configuration { get; }

  public void ConfigureServices(IServiceCollection services)
  {
    // services.AddSwaggerGen(c => { c.SwaggerDoc(
    //   "v1", 
    //   new OpenApiInfo { Title = "CloudBench.Api", Version = "v1" }); });
  }

  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
  {
    if (env.IsDevelopment())
    {
      app.UseDeveloperExceptionPage();
      // app.UseSwagger();
      // app.UseSwaggerUI(c => 
      //   c.SwaggerEndpoint("/swagger/v1/swagger.json", "CloudBench.Api v1"));
    }

    app.UseHttpsRedirection();

    app.UseRouting();

    app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
  }
}