using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            var values = _skillService.GetListAll();
            return View(values);
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = _skillService.GetById(id);
            _skillService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skl)
        {
            _skillService.Insert(skl);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = _skillService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skl)
        {
            _skillService.Update(skl);
            return RedirectToAction("Index");
        }
    }
}
