using LottoLab.Interfaces;
using LottoLab.Services;
using System.IO;
namespace LottoLab.Workers
{
    public class LotoFacilWorker : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly ILogger<LotoFacilWorker> _logger;
        private readonly string _logFolderPath;
        public LotoFacilWorker(ILogger<LotoFacilWorker> logger, IServiceScopeFactory scopeFactory, IConfiguration configuration)
        {
            _logger = logger;
            _scopeFactory = scopeFactory;
            _logFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "Logs"); 
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    try
                    {
                        var supplyServices = scope.ServiceProvider.GetRequiredService<ISupplyServices>();
                        var lastRaffle = await supplyServices.checkLastDrawOnWeb();
                        string message = $"[{DateTime.Now}] Tabela principal nº {lastRaffle}";
                         Console.WriteLine( $"[{DateTime.Now}] Tabela principal nº {lastRaffle}");
                        Log(message);
                    }
                    catch (Exception ex)
                    {
                        string message = $"[{DateTime.Now}] Erro: {ex}";
                        Log(message);
                    }
                }
                await Task.Delay(10000, stoppingToken);
            }
        }
        private void Log(string message)
        {
            try
            {
                if (!Directory.Exists(_logFolderPath))
                {
                    Directory.CreateDirectory(_logFolderPath);
                }
                string logFilePath = Path.Combine(_logFolderPath, "log.txt");
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to write to log file: {ex}", ex);
            }
        }
    }
}
