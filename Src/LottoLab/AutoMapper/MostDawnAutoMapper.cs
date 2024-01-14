using AutoMapper;
using LottoLab.DTO;
using LottoLab.Models;

namespace LottoLab.AutoMapper
{
    public class MostDawnAutoMapper : Profile
    {
        public MostDawnAutoMapper()
        {
            CreateMap<LotoFacilMostDownDTO, LotoFacilMostDown>().ReverseMap();
        }
    }
}