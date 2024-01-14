using LottoLab.DTO;
using LottoLab.Interfaces;
using LottoLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace LottoLab.Controllers
{
    public class ChartsController : Controller
    {
        private readonly ILotoFacilDelayService _delay;
         private readonly ILotoFacilMostDawnServices _mostDawn ;

        public ChartsController(ILotoFacilDelayService delay, ILotoFacilMostDawnServices mostDawn)
        {
            _delay = delay;
            _mostDawn = mostDawn;
        }

        public IActionResult Index()
        {
            return View();
        }

         public IActionResult GraficoAtrazos() {
           var last = _delay.GetLast();
           var atrdto = _delay.GetById(last);
            var atrazos = new LotoFacilDelay(atrdto);
            return View(atrazos);
        }

        // Outros métodos de ação

        // public IActionResult MaisCaem()
        // {
        //     var maisCaem = new MaisCaem();
        //     return View(maisCaem);
        // }

         public IActionResult MaisCaem() {
           var most = _mostDawn.GetLast();
           var mostaD = _mostDawn.GetById(most);
            var maisCaem = new LotoFacilMostDown(mostaD);
            return View(maisCaem);
        }

        

        // public IActionResult Reincidentes()
        // {
        //     return View("Reincidentes");
        // }

        // public IActionResult GraficoLunacao()
        // {
        //     return View("GraficoLunacao");
        // }
    }
}
