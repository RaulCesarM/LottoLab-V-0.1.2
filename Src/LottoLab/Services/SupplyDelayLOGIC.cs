using LottoLab.DTO;
using LottoLab.Interfaces;

namespace LottoLab.Services
{
    public class SupplyDelayLOGIC : ISupplyDelayServices ///SupplyDelayService
    {
        private readonly ILotoFacilDelayService _DelayServices;
        private readonly ILotoFacilServices _BaseServices;
        public SupplyDelayLOGIC(ILotoFacilDelayService delayServices, ILotoFacilServices baseServices)
        {
            _DelayServices = delayServices;
            _BaseServices = baseServices;
        }
        public int checkLastDrawOnWebDelay()
        {
            var lastBase = _BaseServices.GetLast(); 
            var lastDelay = _DelayServices.GetLast(); 
            LotoFacilDTO baseLotofacil = new LotoFacilDTO(); 
            LotoFacilDelayDTO previousDelay = new LotoFacilDelayDTO();
            LotoFacilDelayDTO delay = new LotoFacilDelayDTO();
            int bola1 = 1;
            int bola2 = 1;
            int bola3 = 1;
            int bola4 = 1;
            int bola5 = 1;
            int bola6 = 1;
            int bola7 = 1;
            int bola8 = 1;
            int bola9 = 1;
            int bola10 = 1;
            int bola11 = 1;
            int bola12 = 1;
            int bola13 = 1;
            int bola14 = 1;
            int bola15 = 1;
            int bola16 = 1;
            int bola17 = 1;
            int bola18 = 1;
            int bola19 = 1;
            int bola20 = 1;
            int bola21 = 1;
            int bola22 = 1;
            int bola23 = 1;
            int bola24 = 1;
            int bola25 = 1;
            if (lastBase > lastDelay) //2//1
            {
                lastDelay++;  //2/2
                baseLotofacil = _BaseServices.GetById(lastDelay);//loto 2
                if (lastDelay == 1 || lastDelay == 0)
                {
                     bola1 = 1;
                     bola2 = 1;
                     bola3 = 1;
                     bola4 = 1;
                     bola5 = 1;
                     bola6 = 1;
                     bola7 = 1;
                     bola8 = 1;
                     bola9 = 1;
                     bola10 = 1;
                     bola11 = 1;
                     bola12 = 1;
                     bola13 = 1;
                     bola14 = 1;
                     bola15 = 1;
                     bola16 = 1;
                     bola17 = 1;
                     bola18 = 1;
                     bola19 = 1;
                     bola20 = 1;
                     bola21 = 1;
                     bola22 = 1;
                     bola23 = 1;
                     bola24 = 1;
                     bola25 = 1;
                }
                else if (lastDelay > 2)
                {
                    previousDelay = _DelayServices.GetById(lastDelay - 1);
                    bola1 = previousDelay.bola1 +1;
                    bola2 = previousDelay.bola2 +1;
                    bola3 = previousDelay.bola3 +1;
                    bola4 = previousDelay.bola4 +1;
                    bola5 = previousDelay.bola5 +1;
                    bola6 = previousDelay.bola6 +1;
                    bola7 = previousDelay.bola7 +1;
                    bola8 = previousDelay.bola8 +1;
                    bola9 = previousDelay.bola9 +1;
                    bola10 = previousDelay.bola10 +1;
                    bola11 = previousDelay.bola11 +1;
                    bola12 = previousDelay.bola12 +1;
                    bola13 = previousDelay.bola13+1;
                    bola14 = previousDelay.bola14 +1;
                    bola15 = previousDelay.bola15 +1;
                    bola16 = previousDelay.bola16 +1;
                    bola17 = previousDelay.bola17 +1;
                    bola18 = previousDelay.bola18 +1;
                    bola19 = previousDelay.bola19 +1;
                    bola20 = previousDelay.bola20 +1;
                    bola21 = previousDelay.bola21 +1;
                    bola22 = previousDelay.bola22 +1;
                    bola23 = previousDelay.bola23 +1;
                    bola24 = previousDelay.bola24 +1;
                    bola25 = previousDelay.bola25 +1;
                }
                for (int i = 1; i <= 15; i++)
                {
                    string propertyName = "Casa_" + i;
                    var property = typeof(LotoFacilDTO).GetProperty(propertyName);
                    int ballValue = (int)property.GetValue(baseLotofacil);
                    if (ballValue == 1 )
                    {
                        bola1 = 0;
                    }
                    if (ballValue == 2)
                    {
                        bola2 = 0;
                    }
                    if (ballValue == 3)
                    {
                        bola3 = 0;
                    }
                    if (ballValue == 4)
                    {
                        bola4 = 0;
                    }
                    if (ballValue == 5)
                    {
                        bola5 = 0;
                    }
                    if (ballValue == 6)
                    {
                        bola6 = 0;
                    }
                    if (ballValue == 7)
                    {
                        bola7 = 0;
                    }
                    if (ballValue == 8)
                    {
                        bola8 = 0;
                    }
                    if (ballValue == 9)
                    {
                        bola9 = 0;
                    }
                    if (ballValue == 10)
                    {
                        bola10 = 0;
                    }
                    if (ballValue == 11)
                    {
                        bola11 = 0;
                    }
                    if (ballValue == 12)
                    {
                        bola12 = 0;
                    }
                    if (ballValue == 13)
                    {
                        bola13 = 0;
                    }
                    if (ballValue == 14)
                    {
                        bola14 = 0;
                    }
                    if (ballValue == 15)
                    {
                        bola15 = 0;
                    }
                    if (ballValue == 16)
                    {
                        bola16 = 0;
                    }
                    if (ballValue == 17)
                    {
                        bola17 = 0;
                    }
                    if (ballValue == 18)
                    {
                        bola18 = 0;
                    }
                    if (ballValue == 19)
                    {
                        bola19 = 0;
                    }
                    if (ballValue == 20)
                    {
                        bola20 = 0;
                    }
                    if (ballValue == 21)
                    {
                        bola21 = 0;
                    }
                    if (ballValue == 22)
                    {
                        bola22 = 0;
                    }
                    if (ballValue == 23)
                    {
                        bola23 = 0;
                    }
                    if (ballValue == 24)
                    {
                        bola24 = 0;
                    }
                    if (ballValue == 25)
                    {
                        bola25 = 0;
                    }
                }
                delay.Concurso = baseLotofacil.Concurso;
                delay.Data = baseLotofacil.Data;
                delay.bola1 = bola1;
                delay.bola2 = bola2;
                delay.bola3 = bola3;
                delay.bola4 = bola4;
                delay.bola5 = bola5;
                delay.bola6 = bola6;
                delay.bola7 = bola7;
                delay.bola8 = bola8;
                delay.bola9 = bola9;
                delay.bola10 = bola10;
                delay.bola11 = bola11;
                delay.bola12 = bola12;
                delay.bola13 = bola13;
                delay.bola14 = bola14;
                delay.bola15 = bola15;
                delay.bola16 = bola16;
                delay.bola17 = bola17;
                delay.bola18 = bola18;
                delay.bola19 = bola19;
                delay.bola20 = bola20;
                delay.bola21 = bola21;
                delay.bola22 = bola22;
                delay.bola23 = bola23;
                delay.bola24 = bola24;
                delay.bola25 = bola25;
                _DelayServices.Insert(delay);
            }
            return lastDelay;
        }
    }
}