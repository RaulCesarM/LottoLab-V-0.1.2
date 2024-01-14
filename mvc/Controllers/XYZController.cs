using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LottoLab.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class XYZController : ControllerBase
    {
        private readonly ILogger<XYZController> _logger;
        public XYZController(ILogger<XYZController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult Get()
    {
        return Ok();
    }
    }
}