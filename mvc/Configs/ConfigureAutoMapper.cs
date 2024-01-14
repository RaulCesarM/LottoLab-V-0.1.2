using AutoMapper;
using LottoLab.AutoMapper;

namespace LottoLab.Configs
{
    public class ConfigureAutoMapper
    {
        public static IMapper Configure()
        {
           var configMap = new MapperConfiguration(config => {
            config.AddProfile(new DelayAutoMapper());
            config.AddProfile(new MostDawnAutoMapper());
            config.AddProfile(new RecurrentAutoMapper());
            config.AddProfile(new RecurrentAutoMapper());
           });
           return configMap.CreateMapper(); 
        }
    }
}