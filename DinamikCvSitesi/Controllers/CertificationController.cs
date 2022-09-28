using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.Controllers
{
    public class CertificationController : Controller
    {
        private readonly ICertificationService _certificationService;

        public CertificationController(ICertificationService certificationService)
        {
            _certificationService = certificationService;
        }

        public IActionResult Index()
        {
            var values = _certificationService.GetListAll();
            return View(values);
        }
        public IActionResult DeleteCertification(int id)
        {
            var values = _certificationService.GetById(id);
            _certificationService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddCertification()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCertification(Certification certification)
        {
            _certificationService.Insert(certification);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCertification(int id)
        {
            var values = _certificationService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCertification(Certification certification)
        {


            _certificationService.Update(certification);
            return RedirectToAction("Index");
        }
    }
}
