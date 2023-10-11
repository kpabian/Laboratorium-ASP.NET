using Lab_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab_1.Controllers
{
    public enum Operators
    {
        Add, Sub, Mul, Div
    }


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About(string author, int? id)
        {
            //string author = Request.Query["author"];
            //string strid = Request.Query["id"];
            //if (int.TryParse(strid, out var id))
            //{
            //    ViewBag.Author = author + " id = " + id;
            //}
            if (id == null || author == null) 
            {
                return BadRequest();
            }
            ViewBag.Author = author + " id = " + id;
            return View();
        }

        public IActionResult Calculator(string op, int x, double y)
        {
            double result = 0;
            if(op == "add")
                result = x + y;
            else if (op =="sub")
                result = x - y;
            else if(op =="mul")
                result = x  * y;
            else if (op =="div")
                result = x / y;

            ViewBag.Result = result;

            return View();

        }

        //zadeklaruj metodę calculator z parametrami query:
        //op (string), który może zawierać add, sub, mul, div
        //x, y (double). które zawierają liczby
        //
        //Wynik obliczeń: <x op y>

        public IActionResult Kalkulator([FromQuery(Name = "operator")]Operators op, double? x, double? y)
        {
            if(op == null || x == null || y == null)
                return BadRequest();
            string r = "";
            switch(op)
            {
                case Operators.Add:
                    r = $"{x} + {y} = {x + y}";
                    break;
                case Operators.Sub:
                    r = $"{x} - {y} = {x - y}";
                    break;
                case Operators.Mul:
                    r = $"{x} * {y} = {x * y}";
                    break;
                case Operators.Div:
                    r = $"{x} / {y} = {x / y}";
                    break;
            }
            ViewBag.Result2 = r;
            return View("Error");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}