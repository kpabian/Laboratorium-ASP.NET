using Lab_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_3___App.Controllers
{
    public class CarController : Controller
    {
        static Dictionary<int, Car> _cars = new Dictionary<int, Car>();
        static int id = 0;

        public IActionResult Index()
        {
            return View(_cars);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car model)
        {
            if (ModelState.IsValid)
            {
                model.ID = id++;
                _cars.Add(model.ID, model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(); // ponowne wyświetlenie formularza z informacjami o błędach
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_cars[id]);
        }

        [HttpPost]
        public IActionResult Update(Car model)
        {
            if (ModelState.IsValid)
            {
                _cars[model.ID] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_cars[id]);
        }

        [HttpPost]
        public IActionResult Delete(Car model)
        {
            _cars.Remove(model.ID);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_cars[id]);
        }
        [HttpPost]
        public IActionResult Details()
        {
            return RedirectToAction("Index");
        }
    }
}
