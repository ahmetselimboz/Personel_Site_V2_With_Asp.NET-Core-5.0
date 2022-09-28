using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.Controllers
{
    public class UIController : Controller
    {
        private readonly IContactService _contactService;

        public UIController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Contact c)
        {
            c.Date = DateTime.Now.ToString("dd/MM/yyyy");
            _contactService.Insert(c);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteUI(int id)
        {
            var values = _contactService.GetById(id);
            _contactService.Delete(values);
            return RedirectToAction("Index", "Contact");
        }

    }
}
