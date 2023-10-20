using Microsoft.AspNetCore.Mvc;
using Security.Models;
using System.Diagnostics;

namespace Security.Controllers
{
    public class CezarController : Controller
    {
        private readonly ILogger<CezarController> _logger;

        public CezarController(ILogger<CezarController> logger)
        {
            _logger = logger;
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result([FromForm] Cezar model)
        {

            if (!model.IsValid())
                return View("Result");
            return View(model);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}