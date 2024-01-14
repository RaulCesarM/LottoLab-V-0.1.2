using LottoLab.DTO;
using LottoLab.Interfaces;
namespace LottoLab.Services
{
    public class SupplyDelayService : ISupplyDelayServices
    {
        private readonly ILotoFacilDelayService _DelayServices;
        private readonly ILotoFacilServices _BaseServices;
        public SupplyDelayService(ILotoFacilDelayService delayServices, ILotoFacilServices baseServices)
        {
            _DelayServices = delayServices;
            _BaseServices = baseServices;
        }
         public int checkLastDrawOnWebDelay()
        {
            var lastBase = _BaseServices.GetLast();
            var lastDelay = _DelayServices.GetLast();
            _ = new LotoFacilDTO();
            _ = new LotoFacilDelayDTO();
            LotoFacilDelayDTO delay = new();
            List<int> balls = new();
            for (int i = 0; i < 25; i++)
            {
                balls.Add(1);
            }
            if (lastBase > lastDelay)
            {
                lastDelay++;
                LotoFacilDTO baseLotofacil = _BaseServices.GetById(lastDelay);
                if (lastDelay == 1 || lastDelay == 0)
                {
                    for (int i = 0; i < balls.Count; i++)
                    {
                        balls[i] = 1;
                    }
                }
                else if (lastDelay > 2)
                {
                    LotoFacilDelayDTO previousDelay = _DelayServices.GetById(lastDelay - 1);
                    for (int i = 0; i < balls.Count; i++)
                    {
                        string propertyName = "bola" + (i + 1);
                        var property = typeof(LotoFacilDelayDTO).GetProperty(propertyName);
                        balls[i] = (int)property.GetValue(previousDelay) + 1;
                    }
                }
                for (int i = 0; i < 15; i++)
                {
                    string propertyName = "Casa_" + (i + 1);
                    var property = typeof(LotoFacilDTO).GetProperty(propertyName);
                    int ballValue = (int)property.GetValue(baseLotofacil);
                    if (ballValue == 1)
                    {
                        balls[0] = 0;
                    }
                    if (ballValue >= 2 && ballValue <= 25)
                    {
                        balls[ballValue - 1] = 0;
                    }
                }
                delay.Concurso = baseLotofacil.Concurso;
                delay.Data = baseLotofacil.Data;
                for (int i = 0; i < balls.Count; i++)
                {
                    string propertyName = "bola" + (i + 1);
                    var property = typeof(LotoFacilDelayDTO).GetProperty(propertyName);
                    property.SetValue(delay, balls[i]);
                }
                _DelayServices.Insert(delay);
            }
            return lastDelay;
        }
    }
}
