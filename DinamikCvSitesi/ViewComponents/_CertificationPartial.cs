using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.ViewComponents
{
    public class _CertificationPartial : ViewComponent
    {
        private readonly ICertificationService _certificationService;

        public _CertificationPartial(ICertificationService certificationService)
        {
            _certificationService = certificationService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _certificationService.GetListAll();
            return View(values);
        }
    }
}
