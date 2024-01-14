using LottoLab.DTO;
using LottoLab.Interfaces;
using LottoLab.Models;

namespace LottoLab.Services
{
    public class SupplyMostDawnServices : ISupplyMostDawnServices
    {
        private readonly ILotoFacilMostDawnServices _MostDawnService;
        private readonly ILotoFacilServices _BaseServices;
        public SupplyMostDawnServices(ILotoFacilMostDawnServices mostDawnServices, ILotoFacilServices baseServices)
        {
            _MostDawnService = mostDawnServices;
            _BaseServices = baseServices;
        }
        public int checkLastMostDawn()
        {
            var lastBase = _BaseServices.GetLast(); // pega o ultimo da base
            var last = _MostDawnService.GetLast(); /// pega o ultimo dos que mais cairam
            LotoFacilDTO baseLotofacil = new LotoFacilDTO(); // cria um obk lotofacil
            LotoFacilMostDownDTO PreviusMostDawn = new LotoFacilMostDownDTO();//cria um para armazenar o anterior
            LotoFacilMostDownDTO MostDawn = new LotoFacilMostDownDTO();
            int bola1 = 0;
            int bola2 = 0;
            int bola3 = 0;
            int bola4 = 0;
            int bola5 = 0;
            int bola6 = 0;
            int bola7 = 0;
            int bola8 = 0;
            int bola9 = 0;
            int bola10 = 0;
            int bola11 = 0;
            int bola12 = 0;
            int bola13 = 0;
            int bola14 = 0;
            int bola15 = 0;
            int bola16 = 0;
            int bola17 = 0;
            int bola18 = 0;
            int bola19 = 0;
            int bola20 = 0;
            int bola21 = 0;
            int bola22 = 0;
            int bola23 = 0;
            int bola24 = 0;
            int bola25 = 0;
            if (lastBase > last) //2//1
            {
                last++;  //2/2
                baseLotofacil = _BaseServices.GetById(last);//loto 2
                if (last == 1 || last == 0)
                {
                     bola1 = 0;
                     bola2 = 0;
                     bola3 = 0;
                     bola4 = 0;
                     bola5 = 0;
                     bola6 = 0;
                     bola7 = 0;
                     bola8 = 0;
                     bola9 = 0;
                     bola10 = 0;
                     bola11 = 0;
                     bola12 = 0;
                     bola13 = 0;
                     bola14 = 0;
                     bola15 = 0;
                     bola16 = 0;
                     bola17 = 0;
                     bola18 = 0;
                     bola19 = 0;
                     bola20 = 0;
                     bola21 = 0;
                     bola22 = 0;
                     bola23 = 0;
                     bola24 = 0;
                     bola25 = 0;
                }
                else if (last > 2)
                {
                    PreviusMostDawn = _MostDawnService.GetById(last - 1);
                    bola1 = PreviusMostDawn.bola1;
                    bola2 = PreviusMostDawn.bola2;
                    bola3 = PreviusMostDawn.bola3;
                    bola4 = PreviusMostDawn.bola4;
                    bola5 = PreviusMostDawn.bola5;
                    bola6 = PreviusMostDawn.bola6;
                    bola7 = PreviusMostDawn.bola7;
                    bola8 = PreviusMostDawn.bola8;
                    bola9 = PreviusMostDawn.bola9;
                    bola10 = PreviusMostDawn.bola10;
                    bola11 = PreviusMostDawn.bola11;
                    bola12 = PreviusMostDawn.bola12;
                    bola13 = PreviusMostDawn.bola1;
                    bola14 = PreviusMostDawn.bola14;
                    bola15 = PreviusMostDawn.bola15;
                    bola16 = PreviusMostDawn.bola16;
                    bola17 = PreviusMostDawn.bola17;
                    bola18 = PreviusMostDawn.bola18;
                    bola19 = PreviusMostDawn.bola19;
                    bola20 = PreviusMostDawn.bola20;
                    bola21 = PreviusMostDawn.bola21;
                    bola22 = PreviusMostDawn.bola22;
                    bola23 = PreviusMostDawn.bola23;
                    bola24 = PreviusMostDawn.bola24;
                    bola25 = PreviusMostDawn.bola25;
                }
                for (int i = 1; i <= 15; i++)
                {
                    string propertyName = "Casa_" + i;
                    var property = typeof(LotoFacilDTO).GetProperty(propertyName);
                    int ballValue = (int)property.GetValue(baseLotofacil);
                    if (ballValue == 1 )
                    {
                        ++ bola1;
                    }
                    if (ballValue == 2)
                    {
                       ++ bola2;
                    }
                    if (ballValue == 3)
                    {
                       ++ bola3;
                    }
                    if (ballValue == 4)
                    {
                       ++ bola4;
                    }
                    if (ballValue == 5)
                    {
                       ++ bola5;
                    }
                    if (ballValue == 6)
                    {
                       ++ bola6;
                    }
                    if (ballValue == 7)
                    {
                       ++ bola7;
                    }
                    if (ballValue == 8)
                    {
                       ++ bola8;
                    }
                    if (ballValue == 9)
                    {
                       ++ bola9;
                    }
                    if (ballValue == 10)
                    {
                        ++bola10;
                    }
                    if (ballValue == 11)
                    {
                        ++bola11;
                    }
                    if (ballValue == 12)
                    {
                        ++bola12;
                    }
                    if (ballValue == 13)
                    {
                        ++bola13;
                    }
                    if (ballValue == 14)
                    {
                        ++bola14;
                    }
                    if (ballValue == 15)
                    {
                        ++bola15;
                    }
                    if (ballValue == 16)
                    {
                        ++bola16;
                    }
                    if (ballValue == 17)
                    {
                        ++bola17;
                    }
                    if (ballValue == 18)
                    {
                        ++bola18;
                    }
                    if (ballValue == 19)
                    {
                        ++bola19;
                    }
                    if (ballValue == 20)
                    {
                        ++bola20;
                    }
                    if (ballValue == 21)
                    {
                        ++bola21;
                    }
                    if (ballValue == 22)
                    {
                        ++bola22;
                    }
                    if (ballValue == 23)
                    {
                        ++bola23;
                    }
                    if (ballValue == 24)
                    {
                        ++bola24;
                    }
                    if (ballValue == 25)
                    {
                        ++bola25;
                    }
                }
                MostDawn.Concurso = baseLotofacil.Concurso;
                MostDawn.Data = baseLotofacil.Data;
                MostDawn.bola1 = bola1;
                MostDawn.bola2 = bola2;
                MostDawn.bola3 = bola3;
                MostDawn.bola4 = bola4;
                MostDawn.bola5 = bola5;
                MostDawn.bola6 = bola6;
                MostDawn.bola7 = bola7;
                MostDawn.bola8 = bola8;
                MostDawn.bola9 = bola9;
                MostDawn.bola10 = bola10;
                MostDawn.bola11 = bola11;
                MostDawn.bola12 = bola12;
                MostDawn.bola13 = bola13;
                MostDawn.bola14 = bola14;
                MostDawn.bola15 = bola15;
                MostDawn.bola16 = bola16;
                MostDawn.bola17 = bola17;
                MostDawn.bola18 = bola18;
                MostDawn.bola19 = bola19;
                MostDawn.bola20 = bola20;
                MostDawn.bola21 = bola21;
                MostDawn.bola22 = bola22;
                MostDawn.bola23 = bola23;
                MostDawn.bola24 = bola24;
                MostDawn.bola25 = bola25;
                _MostDawnService.Insert(MostDawn);
            }
            return last;
        }

       
    }
}