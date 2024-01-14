using LottoLab.Context;
using LottoLab.Interfaces;
using LottoLab.Repository;
using LottoLab.Services;
using LottoLab.Workers;
namespace LottoLab;
public class Program
{
    public static async Task Main(string[] args)
    {
        var hostBuilder = CreateHostBuilder(args);
        var host = hostBuilder.Build();
        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var loggerFactory = services.GetRequiredService<ILoggerFactory>();
            try
            {
                var worker = services.GetRequiredService<Worker>();
                await worker.StartAsync(CancellationToken.None);
                await host.RunAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<Program>();
                logger.LogError(ex, "An error occurred while running the worker.");
            }
            finally
            {
                if (host is IAsyncDisposable asyncDisposableHost)
                {
                    await asyncDisposableHost.DisposeAsync();
                }
                else
                {
                    host.Dispose();
                }
            }
        }
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            })
            .ConfigureServices((hostContext, services) =>
            {
                services.AddDbContext<LottoLabContext>();

                services.AddScoped<ILotoFacilRepository, LotoFacilRepository>();
                services.AddScoped<ILotoFacilServices, LotoFacilService>();
                services.AddScoped<ISupplyServices, SupplyServices>();
                
                services.AddScoped<ILotoFacilDelayRepository, LotoFacilDelayRepository>();
                services.AddScoped<ISupplyDelayServices, SupplyDelayService>();
                services.AddScoped<ILotoFacilDelayService, LotoFacilDelayService>();
                
                services.AddScoped<ILotoFacilRNARepository, LotoFacilRNARepository>();
                services.AddScoped<ILotoFacilRNAServices, LotoFacilRNAServices>();
                services.AddScoped<ISupplyRNAServices, SupplyRNAService>();

                services.AddScoped<ILotoFacilMostDawnRepository, LotoFacilMostDawnRepository>();
                services.AddScoped<ILotoFacilMostDawnServices, LotoFacilMostDawnServices>();
                services.AddScoped<ISupplyMostDawnServices, SupplyMostDawnServices>();


                services.AddHostedService<LotoFacilWorker>();
                services.AddHostedService<MostDawnWorker>();
                services.AddHostedService<RNAWorker>();
                services.AddHostedService<DelayWorker>();
                services.AddHostedService<Worker>();


                
            });
}