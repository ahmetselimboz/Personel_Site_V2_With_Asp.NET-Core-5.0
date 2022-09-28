using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.Controllers
{
    public class InterestController : Controller
    {
        private readonly IInterestService _ınterestService;

        public InterestController(IInterestService ınterestService)
        {
            _ınterestService = ınterestService;
        }

        public IActionResult Index()
        {
            var values = _ınterestService.GetListAll();
            return View(values);
        }

        public IActionResult DeleteInterest(int id)
        {
            var values = _ınterestService.GetById(id);
            _ınterestService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddInterest()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInterest(Interest inter)
        {
            _ınterestService.Insert(inter);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateInterest(int id)
        {
            var values = _ınterestService.GetById(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateInterest(Interest inter)
        {
            _ınterestService.Update(inter);
            return RedirectToAction("index");

        }
    }
}
