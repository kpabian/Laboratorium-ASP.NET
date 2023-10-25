using Lab_3___App.Models.Contact;
using Microsoft.AspNetCore.Mvc;

namespace Lab_3___App.Controllers
{
    public class ContactController : Controller
    {
        public readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if(ModelState.IsValid)
            {
                _contactService.Add(model);

                //dodaj model do bazy lub kolekcji
                //model.Id = id++;
                //_contacts.Add(model.Id, model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_contactService.FindById(id));
        }
        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            { 
                _contactService.Update(model);
                //dodaj model do bazy lub kolekcji
                //_contacts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contactService.FindById(id));
        }
        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contactService.RemoveById(model.Id);
            //_contacts.Remove(model.Id);
            return RedirectToAction("Index");
        }

        ////[HttpGet]
        ////public IActionResult Get(int id)
        ////{
        ////    return View(_contactService.FindById(id));
        ////}
    }
}
