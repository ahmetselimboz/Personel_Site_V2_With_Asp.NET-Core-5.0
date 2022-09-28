using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using DinamikCvSitesi.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly string wwwrootDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            var values = _projectService.GetListAll();
            return View(values);
            
        }

        public IActionResult DeleteProject(int id)
        {
            var values = _projectService.GetById(id);
            _projectService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProject(Project p)
        {

            _projectService.Insert(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProject(int id)
        {
            var values = _projectService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateProject(Project p)
        {
            _projectService.Update(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddImage(AddProfileImage i)
        {
            CvContext c = new CvContext();
            Project p = new Project();

            if (i.Image!=null)
            {
                
                var extension = Path.GetExtension(i.Image.FileName);
                
                var filename = Path.GetFileNameWithoutExtension(i.Image.FileName);
                //var newimagename = Guid.NewGuid() + extension;
                filename = filename + extension;
                string path = Path.Combine(wwwrootDirectory+"/ImagesFile/" + filename);
                var stream = new FileStream(path, FileMode.Create);
                
                i.Image.CopyTo(stream);
                p.Image = filename;

                p.ProjectName = i.ProjectName;
                p.Description = i.Description;
                p.Date = i.Date;



                _projectService.Insert(p);
                return RedirectToAction("Index");

            }
           
            return View(i);

        }

    }
}
