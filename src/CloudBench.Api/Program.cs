using CloudBench.Api;

Host
  .CreateDefaultBuilder(args)
  .ConfigureWebHostDefaults(builder =>
  {
    builder.UseStartup<Startup>();
  })
  .Build()
  .Run();