using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            var values = _experienceService.GetListAll();
            return View(values);
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = _experienceService.GetById(id);
            _experienceService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience exp)
        {
            _experienceService.Insert(exp);
            return RedirectToAction("Index");
        }





        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values = _experienceService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience exp)
        {
            _experienceService.Update(exp);
            return RedirectToAction("Index");
        }
    }
}
