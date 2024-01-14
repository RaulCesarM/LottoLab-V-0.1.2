using AutoMapper;
using LottoLab.DTO;
using LottoLab.Models;

namespace LottoLab.AutoMapper
{
    public class RNAAutoMapper : Profile
    {
        public RNAAutoMapper()
        {
            CreateMap<LotoFacilRNADTO, LotoFacilRNA>().ReverseMap();
        }
    }
}