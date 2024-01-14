
using LottoLab.Models;

namespace LottoLab.DTO
{
    public class LotoFacilDelayDTO
    {
      /// <summary>
      /// converter as propriedades para maiusculas
      /// </summary>
         public int Id { get; set; }
        public int Concurso { get; set; }
        public string Data { get; set; }
        public int bola1 { get; set; }
        public int bola2 { get; set; }
        public int bola3 { get; set; }
        public int bola4 { get; set; }
        public int bola5 { get; set; }
        public int bola6 { get; set; }
        public int bola7 { get; set; }
        public int bola8 { get; set; }
        public int bola9 { get; set; }
        public int bola10 { get; set; }
        public int bola11 { get; set; }
        public int bola12 { get; set; }
        public int bola13 { get; set; }
        public int bola14 { get; set; }
        public int bola15 { get; set; }
        public int bola16 { get; set; }
        public int bola17 { get; set; }
        public int bola18 { get; set; }
        public int bola19 { get; set; }
        public int bola20 { get; set; }
        public int bola21 { get; set; }
        public int bola22 { get; set; }
        public int bola23 { get; set; }
        public int bola24 { get; set; }
        public int bola25 { get; set; }

        public LotoFacilDelayDTO()
        {
            
        }

       public LotoFacilDelayDTO(LotoFacilDelay entity)
        {
            Id = entity.Id;
            Concurso = entity.Concurso;
            Data = entity.Data;
            bola1 = entity.bola1;
            bola2 = entity.bola2;
            bola3 = entity.bola3;
            bola4 = entity.bola4;
            bola5 = entity.bola5;
            bola6 = entity.bola6;
            bola7 = entity.bola7;
            bola8 = entity.bola8;
            bola9 = entity.bola9;
            bola10 = entity.bola10;
            bola11 = entity.bola11;
            bola12 = entity.bola12;
            bola13 = entity.bola13;
            bola14 = entity.bola14;
            bola15 = entity.bola15;
            bola16 = entity.bola16;
            bola17 = entity.bola17;
            bola18 = entity.bola18;
            bola19 = entity.bola19;
            bola20 = entity.bola20;
            bola21 = entity.bola21;
            bola22 = entity.bola22;
            bola23 = entity.bola23;
            bola24 = entity.bola24;
            bola25 = entity.bola25;
        }
         public LotoFacilDelayDTO(int numero, string dataApuracao)
        {
            this.Id = numero;
            this.Concurso = numero;
            this.Data = dataApuracao;
        } 
       
    }
}
   