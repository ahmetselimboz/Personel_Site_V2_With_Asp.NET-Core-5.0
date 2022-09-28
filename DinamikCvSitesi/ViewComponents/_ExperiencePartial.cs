using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.ViewComponents
{
    public class _ExperiencePartial : ViewComponent
    {
        private readonly IExperienceService _experienceService;

        public _ExperiencePartial(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _experienceService.GetListAll().OrderByDescending(x => x.ExperienceID).ToList(); ;
            return View(values);
        }
    }
}
