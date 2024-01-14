using AutoMapper;
using LottoLab.DTO;
using LottoLab.Models;

namespace LottoLab.AutoMapper
{
    public class DelayAutoMapper : Profile
    {
        public DelayAutoMapper()
        {
            CreateMap<LotoFacilDelayDTO, LotoFacilDelay>().ReverseMap();
        }
    }
}