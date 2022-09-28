using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.ViewComponents
{
    public class _InterestPartial : ViewComponent
    {
        private readonly IInterestService _interestService;

        public _InterestPartial(IInterestService ınterestService)
        {
            _interestService = ınterestService;
        }

        public IViewComponentResult Invoke()
        {
            var valeus = _interestService.GetListAll();
            return View(valeus);
        }

    }
}
