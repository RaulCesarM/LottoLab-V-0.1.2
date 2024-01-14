using LottoLab.Models;

namespace LottoLab.DTO
{
    public class LotoFacilRNADTO
    {
        public int Id { get; set; }
        public int Concurso { get; set; }
        public string Data { get; set; }
        public char bola1 { get; set; }
        public char bola2 { get; set; }
        public char bola3 { get; set; }
        public char bola4 { get; set; }
        public char bola5 { get; set; }
        public char bola6 { get; set; }
        public char bola7 { get; set; }
        public char bola8 { get; set; }
        public char bola9 { get; set; }
        public char bola10 { get; set; }
        public char bola11 { get; set; }
        public char bola12 { get; set; }
        public char bola13 { get; set; }
        public char bola14 { get; set; }
        public char bola15 { get; set; }
        public char bola16 { get; set; }
        public char bola17 { get; set; }
        public char bola18 { get; set; }
        public char bola19 { get; set; }
        public char bola20 { get; set; }
        public char bola21 { get; set; }
        public char bola22 { get; set; }
        public char bola23 { get; set; }
        public char bola24 { get; set; }
        public char bola25 { get; set; }
        public LotoFacilRNADTO()
        {
        }
       public LotoFacilRNADTO(LotoFacilRNA entity)
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
         public LotoFacilRNADTO(int numero, string dataApuracao)
        {
            this.Id = numero;
            this.Concurso = numero;
            this.Data = dataApuracao;
        } 
    }
}