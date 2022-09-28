using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.ViewComponents
{
    public class _NavigationPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _NavigationPartial(IAboutService aboutService
            )
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.GetListAll();
            return View(values);
        }
    }
}
