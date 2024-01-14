using LottoLab.Interfaces;
using LottoLab.Models;
using LottoLab.Services;
using Microsoft.AspNetCore.Mvc;

namespace LottoLab.Controllers
{
    public class TabelaController : Controller
    {
        private readonly ILotoFacilRNAServices _lotoFacilRNAService;

        public TabelaController(ILotoFacilRNAServices lotoFacilRNAService)
        {
            _lotoFacilRNAService = lotoFacilRNAService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult TabelaElementar()
        {
            return View("~/Views/PanelTable/TabelaElementar.cshtml");
        }

        public IActionResult TabelaPadrao()
        {
            int totalCount = _lotoFacilRNAService.GetTotal();
            IList<LotoFacilRNA> listaPadroes = _lotoFacilRNAService.GetLastRecords(25);
            listaPadroes = listaPadroes.OrderBy(x => x.Id).ToList();
            return View("~/Views/PanelTable/TabelaPadrao.cshtml", listaPadroes);
        }
    }
}
