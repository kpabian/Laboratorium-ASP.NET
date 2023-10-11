using Lab_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result([FromForm] Calculator model)
        {
            if (!model.IsValid())
                return View("Result");
            return View(model);

        }

    }
}
