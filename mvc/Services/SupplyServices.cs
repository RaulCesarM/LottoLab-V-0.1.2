
using LottoLab.DTO;
using LottoLab.Interfaces;
using LottoLab.Models;
using Newtonsoft.Json;

namespace LottoLab.Services
{
    public class SupplyServices : ISupplyServices
    {
        private readonly ILotoFacilServices _services;     
        private readonly string _url;
        private readonly IConfiguration _configuration; 
        static readonly HttpClient Client = new HttpClient { MaxResponseContentBufferSize = 1_000_000 };
        public SupplyServices(){}
        public SupplyServices(ILotoFacilServices services, IConfiguration configuration)
        {
            _configuration = configuration;
            _services = services;
            _url = configuration.GetSection("LotofacilApi")["Url"];
        }
        public async Task<int> checkLastDrawOnWeb()
        {
             var lastWeb = await Client.GetStringAsync(_url);
            dynamic lastRaffleWebObj = JsonConvert.DeserializeObject(lastWeb);
            int lastRaffleWEB = lastRaffleWebObj.numero;
            int lastRaffleDB = _services.GetLast();
            if (lastRaffleDB < lastRaffleWEB)
            {
                lastRaffleDB++;
                await populateDatabaseWithNewDraws(lastRaffleDB);
            }
            else
            {
                Console.WriteLine("Banco atualizado");
            }
            return lastRaffleDB;
        }

        public async  Task populateDatabaseWithNewDraws(int lastDrawDB)
        {
            var result = await Client.GetStringAsync($"{_url}/{lastDrawDB}");
            var obj = JsonConvert.DeserializeObject<LoteriaJson>(result);
            var raffle = new LotoFacilDTO(obj.Numero, obj.DataApuracao);
            for (var i = 0; i < 15; i++)
            {
                var J = i + 1;
                var casa = obj.DezenasSorteadasOrdemSorteio[i];
                raffle.GetType().GetProperty("Casa_" + J).SetValue(raffle, casa);
            }
            _services.Insert(raffle);
        }

        
    }
}