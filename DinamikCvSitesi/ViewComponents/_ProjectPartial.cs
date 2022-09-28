using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.ViewComponents
{
    public class _ProjectPartial : ViewComponent
    {
        private readonly IProjectService _projectService;

        public _ProjectPartial(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _projectService.GetListAll();
            return View(values);
        }
    }
}
