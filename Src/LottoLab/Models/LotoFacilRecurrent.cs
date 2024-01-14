using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LottoLab.DTO;

namespace LottoLab.Models
{
    public class LotoFacilRecurrent
    {
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

        public LotoFacilRecurrent()
        {
            
        }

        public LotoFacilRecurrent(LotoFacilRecurrentDTO dto)
        {
             Id = dto.Id;
            Concurso = dto.Concurso;
            Data = dto.Data;
            bola1 = dto.bola1;
            bola2 = dto.bola2;
            bola3 = dto.bola3;
            bola4 = dto.bola4;
            bola5 = dto.bola5;
            bola6 = dto.bola6;
            bola7 = dto.bola7;
            bola8 = dto.bola8;
            bola9 = dto.bola9;
            bola10 = dto.bola10;
            bola11 = dto.bola11;
            bola12 = dto.bola12;
            bola13 = dto.bola13;
            bola14 = dto.bola14;
            bola15 = dto.bola15;
            bola16 = dto.bola16;
            bola17 = dto.bola17;
            bola18 = dto.bola18;
            bola19 = dto.bola19;
            bola20 = dto.bola20;
            bola21 = dto.bola21;
            bola22 = dto.bola22;
            bola23 = dto.bola23;
            bola24 = dto.bola24;
            bola25 = dto.bola25;
            
        }
    }
}