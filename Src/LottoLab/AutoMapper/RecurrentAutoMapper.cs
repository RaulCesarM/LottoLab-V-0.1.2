using AutoMapper;
using LottoLab.DTO;
using LottoLab.Models;

namespace LottoLab.AutoMapper
{
    public class RecurrentAutoMapper : Profile
    {
        public RecurrentAutoMapper()
        {
            CreateMap<LotoFacilRecurrentDTO, LotoFacilRecurrent>().ReverseMap();
        }
    }
}