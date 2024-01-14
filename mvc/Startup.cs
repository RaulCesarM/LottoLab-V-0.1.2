using LottoLab.Context;
using LottoLab.Interfaces;
using LottoLab.Repository;
using LottoLab.Services;
using Microsoft.OpenApi.Models;

namespace LottoLab;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddScoped<LottoLab.Services.LotoFacilRNAServices>();
        services.AddScoped<Worker>();
          services.AddScoped<ILotoFacilDelayService, LotoFacilDelayService>();
           
                services.AddScoped<ILotoFacilRepository, LotoFacilRepository>();
                services.AddScoped<ILotoFacilServices, LotoFacilService>();
                services.AddScoped<ISupplyServices, SupplyServices>();
                
                services.AddScoped<ILotoFacilDelayRepository, LotoFacilDelayRepository>();
                services.AddScoped<ISupplyDelayServices, SupplyDelayService>();
                services.AddScoped<ILotoFacilDelayService, LotoFacilDelayService>();


                services.AddScoped<ILotoFacilRNARepository, LotoFacilRNARepository>();
                services.AddScoped<ILotoFacilRNAServices, LotoFacilRNAServices>();
                services.AddScoped<ISupplyRNAServices, SupplyRNAService>();
                services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "LottoLabAPI", Version = "v1" });
    });
                
            
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }
        app.UseSwagger();
        app.UseSwaggerUI(c =>{
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "LottoLabAPI V1");
        });

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            endpoints.MapControllerRoute(
                name: "TabelaPadrao",
                pattern: "TabelaPadrao",
                defaults: new { controller = "Home", action = "login" }
            );

            endpoints.MapControllerRoute(
              name: "GraficoAtrazos",
               pattern: "GraficoAtrazos",
                 defaults: new { controller = "Charts", action = "GraficoAtrazos" }
             );

            endpoints.MapControllerRoute(
                name: "MaisCaem",
                pattern: "graficos-maiscaem",
                defaults: new { controller = "Charts", action = "MaisCaem" }
            );

            endpoints.MapControllerRoute(
                name: "Reincidentes",
                pattern: "graficos-reincidentes",
                defaults: new { controller = "Charts", action = "Reincidentes" }
            );

            endpoints.MapControllerRoute(
                name: "GraficoLunacao",
                pattern: "grafico-lunacao",
                defaults: new { controller = "Charts", action = "GraficoLunacao" }
            );

            endpoints.MapControllerRoute(
                name: "TabelaElementar",
                pattern: "TabelaElementar",
                defaults: new { controller = "Tabela", action = "TabelaElementar" }
            );
             endpoints.MapControllerRoute(
                name: "TabelaPadrao",
                pattern: "TabelaPadrao",
                defaults: new { controller = "Tabela", action = "TabelaPadrao" }
            );


        });
    }
}
