using Microsoft.AspNetCore.Mvc;
using Security.Models;
using System.Diagnostics;

namespace Security.Controllers
{
    public class PolibiuszController : Controller
    {
        private readonly ILogger<CezarController> _logger;

        public PolibiuszController(ILogger<PolibiuszController> logger)
        {
            //_logger = logger;
        }

        public IActionResult Form()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}