using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.Controllers
{
    public class EducationController : Controller
    {
        private readonly IEducationService _educationService;

        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public IActionResult Index()
        {
            var values = _educationService.GetListAll();
            return View(values);
        }
        public IActionResult DeleteEducation(int id)
        {
            var values = _educationService.GetById(id);
            _educationService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEducation(Education Educa)
        {
            _educationService.Insert(Educa);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var values = _educationService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateEducation(Education Educa)
        {
            _educationService.Update(Educa);
            return RedirectToAction("Index");
        }
    }
}
