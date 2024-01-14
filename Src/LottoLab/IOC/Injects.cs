using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LottoLab.Interfaces;
using LottoLab.Repository;
using LottoLab.Services;

namespace LottoLab.IOC
{
    public class Injects
    {
        public static void RegisterServices(IServiceCollection builder)
        {
            builder.AddScoped<ILotoFacilServices, LotoFacilService>();
            builder.AddScoped<ILotoFacilRepository, LotoFacilRepository>();
            builder.AddScoped<ISupplyServices, SupplyServices>();

          
            
        }
    }
}