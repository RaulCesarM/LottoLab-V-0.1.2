using LottoLab.DTO;
using LottoLab.Interfaces;
namespace LottoLab.Services
{
    public class SupplyRNAService : ISupplyRNAServices
    {
        private readonly ILotoFacilRNAServices _RNAServices;
        private readonly ILotoFacilDelayService _DelayServices;
        public SupplyRNAService(ILotoFacilDelayService delayServices, ILotoFacilRNAServices RNAServices)
        {
            _DelayServices = delayServices;
            _RNAServices = RNAServices;
        }
        public int checkLastRNA()
        {
            var lastDelay = _DelayServices.GetLast();// ultimo do atraso
            var lastRNA = _RNAServices.GetLast();// ultimo rna registrado
            LotoFacilDelayDTO previousDelay = new LotoFacilDelayDTO();
            LotoFacilDelayDTO delay = new LotoFacilDelayDTO();
            LotoFacilRNADTO rna = new LotoFacilRNADTO();
            rna.bola1 = 'A';
            rna.bola2 = 'A';
            rna.bola3 = 'A';
            rna.bola4 = 'A';
            rna.bola5 = 'A';
            rna.bola6 = 'A';
            rna.bola7 = 'A';
            rna.bola8 = 'A';
            rna.bola9 = 'A';
            rna.bola10 = 'A';
            rna.bola11 = 'A';
            rna.bola12 = 'A';
            rna.bola13 = 'A';
            rna.bola14 = 'A';
            rna.bola15 = 'A';
            rna.bola16 = 'A';
            rna.bola17 = 'A';
            rna.bola18 = 'A';
            rna.bola19 = 'A';
            rna.bola20 = 'A';
            rna.bola21 = 'A';
            rna.bola22 = 'A';
            rna.bola23 = 'A';
            rna.bola24 = 'A';
            rna.bola25 = 'A';
            if (lastDelay > lastRNA)
            {
             
                lastRNA++;
                delay = _DelayServices.GetById(lastDelay);
                if(lastRNA == 1 || lastRNA == 0){
                     previousDelay = _DelayServices.GetById(lastRNA);
                }else{
                     previousDelay = _DelayServices.GetById(lastRNA -1);
                }
               
                if (lastRNA == 1 || lastRNA == 0)
                {
                    rna.bola1 = 'A';
                    rna.bola2 = 'A';
                    rna.bola3 = 'A';
                    rna.bola4 = 'A';
                    rna.bola5 = 'A';
                    rna.bola6 = 'A';
                    rna.bola7 = 'A';
                    rna.bola8 = 'A';
                    rna.bola9 = 'A';
                    rna.bola10 = 'A';
                    rna.bola11 = 'A';
                    rna.bola12 = 'A';
                    rna.bola13 = 'A';
                    rna.bola14 = 'A';
                    rna.bola15 = 'A';
                    rna.bola16 = 'A';
                    rna.bola17 = 'A';
                    rna.bola18 = 'A';
                    rna.bola19 = 'A';
                    rna.bola20 = 'A';
                    rna.bola21 = 'A';
                    rna.bola22 = 'A';
                    rna.bola23 = 'A';
                    rna.bola24 = 'A';
                    rna.bola25 = 'A';

                }
                else if (lastRNA > 2)
                {

                    if (previousDelay.bola1 == 0 && delay.bola1 == 0)
                    {
                        rna.bola1 = 'R';
                    }
                    else if (previousDelay.bola1 >= 1 && delay.bola1 == 0)
                    {
                        rna.bola1 = 'N';
                    }
                    else if (delay.bola1 > 1)
                    {
                        rna.bola1 = 'A';
                    }
                    if (previousDelay.bola2 == 0 && delay.bola2 == 0)
                    {
                        rna.bola2 = 'R';
                    }
                    else if (previousDelay.bola2 >= 1 && delay.bola2 == 0)
                    {
                        rna.bola2 = 'N';
                    }
                    else if (delay.bola2 > 1)
                    {
                        rna.bola2 = 'A';
                    }
                    if (previousDelay.bola3 == 0 && delay.bola3 == 0)
                    {
                        rna.bola3 = 'R';
                    }
                    else if (previousDelay.bola3 >= 1 && delay.bola3 == 0)
                    {
                        rna.bola3 = 'N';
                    }
                    else if (delay.bola3 > 1)
                    {
                        rna.bola3 = 'A';
                    }
                    if (previousDelay.bola4 == 0 && delay.bola4 == 0)
                    {
                        rna.bola4 = 'R';
                    }
                    else if (previousDelay.bola4 >= 1 && delay.bola4 == 0)
                    {
                        rna.bola4 = 'N';
                    }
                    else if (delay.bola4 > 1)
                    {
                        rna.bola4 = 'A';
                    }
                    if (previousDelay.bola5 == 0 && delay.bola5 == 0)
                    {
                        rna.bola5 = 'R';
                    }
                    else if (previousDelay.bola5 >= 1 && delay.bola5 == 0)
                    {
                        rna.bola5 = 'N';
                    }
                    else if (delay.bola5 > 1)
                    {
                        rna.bola5 = 'A';
                    }
                    if (previousDelay.bola6 == 0 && delay.bola6 == 0)
                    {
                        rna.bola6 = 'R';
                    }
                    else if (previousDelay.bola6 >= 1 && delay.bola6 == 0)
                    {
                        rna.bola6 = 'N';
                    }
                    else if (delay.bola6 > 1)
                    {
                        rna.bola6 = 'A';
                    }
                    if (previousDelay.bola7 == 0 && delay.bola7 == 0)
                    {
                        rna.bola7 = 'R';
                    }
                    else if (previousDelay.bola7 >= 1 && delay.bola7 == 0)
                    {
                        rna.bola7 = 'N';
                    }
                    else if (delay.bola7 > 1)
                    {
                        rna.bola7 = 'A';
                    }
                    if (previousDelay.bola8 == 0 && delay.bola8 == 0)
                    {
                        rna.bola8 = 'R';
                    }
                    else if (previousDelay.bola8 >= 1 && delay.bola8 == 0)
                    {
                        rna.bola8 = 'N';
                    }
                    else if (delay.bola8 > 1)
                    {
                        rna.bola8 = 'A';
                    }
                    if (previousDelay.bola9 == 0 && delay.bola9 == 0)
                    {
                        rna.bola9 = 'R';
                    }
                    else if (previousDelay.bola9 >= 1 && delay.bola9 == 0)
                    {
                        rna.bola9 = 'N';
                    }
                    else if (delay.bola9 > 1)
                    {
                        rna.bola9 = 'A';
                    }
                    if (previousDelay.bola10 == 0 && delay.bola10 == 0)
                    {
                        rna.bola10 = 'R';
                    }
                    else if (previousDelay.bola10 >= 1 && delay.bola10 == 0)
                    {
                        rna.bola10 = 'N';
                    }
                    else if (delay.bola10 > 1)
                    {
                        rna.bola10 = 'A';
                    }
                    if (previousDelay.bola11 == 0 && delay.bola11 == 0)
                    {
                        rna.bola11 = 'R';
                    }
                    else if (previousDelay.bola11 >= 1 && delay.bola11 == 0)
                    {
                        rna.bola11 = 'N';
                    }
                    else if (delay.bola11 > 1)
                    {
                        rna.bola11 = 'A';
                    }
                    if (previousDelay.bola12 == 0 && delay.bola12 == 0)
                    {
                        rna.bola12 = 'R';
                    }
                    else if (previousDelay.bola12 >= 1 && delay.bola12 == 0)
                    {
                        rna.bola12 = 'N';
                    }
                    else if (delay.bola12 > 1)
                    {
                        rna.bola12 = 'A';
                    }
                    if (previousDelay.bola13 == 0 && delay.bola13 == 0)
                    {
                        rna.bola13 = 'R';
                    }
                    else if (previousDelay.bola13 >= 1 && delay.bola13 == 0)
                    {
                        rna.bola13 = 'N';
                    }
                    else if (delay.bola13 > 1)
                    {
                        rna.bola13 = 'A';
                    }
                    if (previousDelay.bola14 == 0 && delay.bola14 == 0)
                    {
                        rna.bola14 = 'R';
                    }
                    else if (previousDelay.bola14 >= 1 && delay.bola14 == 0)
                    {
                        rna.bola14 = 'N';
                    }
                    else if (delay.bola14 > 1)
                    {
                        rna.bola14 = 'A';
                    }
                    if (previousDelay.bola15 == 0 && delay.bola15 == 0)
                    {
                        rna.bola15 = 'R';
                    }
                    else if (previousDelay.bola15 >= 1 && delay.bola15 == 0)
                    {
                        rna.bola15 = 'N';
                    }
                    else if (delay.bola15 > 1)
                    {
                        rna.bola15 = 'A';
                    }
                    if (previousDelay.bola16 == 0 && delay.bola16 == 0)
                    {
                        rna.bola16 = 'R';
                    }
                    else if (previousDelay.bola16 >= 1 && delay.bola16 == 0)
                    {
                        rna.bola16 = 'N';
                    }
                    else if (delay.bola16 > 1)
                    {
                        rna.bola16 = 'A';
                    }
                    if (previousDelay.bola17 == 0 && delay.bola17 == 0)
                    {
                        rna.bola17 = 'R';
                    }
                    else if (previousDelay.bola17 >= 1 && delay.bola17 == 0)
                    {
                        rna.bola17 = 'N';
                    }
                    else if (delay.bola17 > 1)
                    {
                        rna.bola17 = 'A';
                    }
                    if (previousDelay.bola18 == 0 && delay.bola18 == 0)
                    {
                        rna.bola18 = 'R';
                    }
                    else if (previousDelay.bola18 >= 1 && delay.bola18 == 0)
                    {
                        rna.bola18 = 'N';
                    }
                    else if (delay.bola18 > 1)
                    {
                        rna.bola18 = 'A';
                    }
                    if (previousDelay.bola19 == 0 && delay.bola19 == 0)
                    {
                        rna.bola19 = 'R';
                    }
                    else if (previousDelay.bola19 >= 1 && delay.bola19 == 0)
                    {
                        rna.bola19 = 'N';
                    }
                    else if (delay.bola19 > 1)
                    {
                        rna.bola19 = 'A';
                    }
                    if (previousDelay.bola20 == 0 && delay.bola20 == 0)
                    {
                        rna.bola20 = 'R';
                    }
                    else if (previousDelay.bola20 >= 1 && delay.bola20 == 0)
                    {
                        rna.bola20 = 'N';
                    }
                    else if (delay.bola20 > 1)
                    {
                        rna.bola20 = 'A';
                    }
                    if (previousDelay.bola21 == 0 && delay.bola21 == 0)
                    {
                        rna.bola21 = 'R';
                    }
                    else if (previousDelay.bola21 >= 1 && delay.bola21 == 0)
                    {
                        rna.bola21 = 'N';
                    }
                    else if (delay.bola21 > 1)
                    {
                        rna.bola21 = 'A';
                    }
                    if (previousDelay.bola22 == 0 && delay.bola22 == 0)
                    {
                        rna.bola22 = 'R';
                    }
                    else if (previousDelay.bola22 >= 1 && delay.bola22 == 0)
                    {
                        rna.bola22 = 'N';
                    }
                    else if (delay.bola22 > 1)
                    {
                        rna.bola22 = 'A';
                    }
                    if (previousDelay.bola23 == 0 && delay.bola23 == 0)
                    {
                        rna.bola23 = 'R';
                    }
                    else if (previousDelay.bola23 >= 1 && delay.bola23 == 0)
                    {
                        rna.bola23 = 'N';
                    }
                    else if (delay.bola23 > 1)
                    {
                        rna.bola23 = 'A';
                    }
                    if (previousDelay.bola24 == 0 && delay.bola24 == 0)
                    {
                        rna.bola24 = 'R';
                    }
                    else if (previousDelay.bola24 >= 1 && delay.bola24 == 0)
                    {
                        rna.bola24 = 'N';
                    }
                    else if (delay.bola24 > 1)
                    {
                        rna.bola24 = 'A';
                    }
                    if (previousDelay.bola25 == 0 && delay.bola25 == 0)
                    {
                        rna.bola25 = 'R';
                    }
                    else if (previousDelay.bola25 >= 1 && delay.bola25 == 0)
                    {
                        rna.bola25 = 'N';
                    }
                    else if (delay.bola25 > 1)
                    {
                        rna.bola25 = 'A';
                    }

                }



                rna.Concurso = delay.Concurso;
                rna.Data = delay.Data;
                _RNAServices.Insert(rna);
            }
            return lastDelay;
        }
    }
}