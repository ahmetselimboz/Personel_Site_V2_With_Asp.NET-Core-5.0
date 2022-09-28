using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.ViewComponents
{
    public class _EducationPartial : ViewComponent
    {
        private readonly IEducationService _educationService;

        public _EducationPartial(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _educationService.GetListAll().OrderByDescending(x=>x.EducationID).ToList();
            return View(values);
        }
    }
}
