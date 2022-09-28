using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using DinamikCvSitesi.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly string wwwrootDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {



            var values = _aboutService.GetListAll();
            return View(values);


        }
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.GetById(id);
            _aboutService.Delete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _aboutService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About p)
        {
            CvContext c = new CvContext();

            var key = c.Abouts.SingleOrDefault(x => x.AboutID == 1);
            key.Name = p.Name;
            key.Surname = p.Surname;
            key.Title = p.Title;
            key.Description = p.Description;

            _aboutService.Update(key);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddAbout()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddAbout(AddAboutImage i)
        {
            CvContext c = new CvContext();
            About p = new About();

            if (i.Image != null)
            {

                var extension = Path.GetExtension(i.Image.FileName);

                var filename = Path.GetFileNameWithoutExtension(i.Image.FileName);
                //var newimagename = Guid.NewGuid() + extension;
                filename = filename + extension;
                string path = Path.Combine(wwwrootDirectory + "/ImagesFile/" + filename);
                var stream = new FileStream(path, FileMode.Create);

                i.Image.CopyTo(stream);

                var key = c.Abouts.SingleOrDefault(x => x.AboutID == 1);
                key.Image = " ";
                key.Image = filename;

                _aboutService.Update(key);
                return RedirectToAction("Index");

            }

            return View(i);




        }

    }
}
