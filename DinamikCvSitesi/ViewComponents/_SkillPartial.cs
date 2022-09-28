using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.ViewComponents
{
    public class _SkillPartial : ViewComponent
    {
        private readonly ISkillService _skillService;

        public _SkillPartial(ISkillService skillService
            )
        {
            _skillService = skillService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _skillService.GetListAll();
            return View(values);
        }
    }
}
